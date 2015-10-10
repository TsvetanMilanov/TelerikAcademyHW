namespace SqlStringConcat
{
    using System.Data.SqlTypes;
    using System.IO;
    using System.Text;
    using Microsoft.SqlServer.Server;

    [System.Serializable]
    [
       Microsoft.SqlServer.Server.SqlUserDefinedAggregate(
       Microsoft.SqlServer.Server.Format.UserDefined,
       IsInvariantToDuplicates = false,
       IsInvariantToNulls = false,
       IsInvariantToOrder = false,
       IsNullIfEmpty = true,
       MaxByteSize = -1,
       Name = "StringConcat")
    ]
    public struct StringConcat : IBinarySerialize
    {
        public StringBuilder Result { get; private set; }

        public SqlString Delimiter { get; private set; }

        public bool HasValue { get; private set; }

        public bool IsNull { get; private set; }

        public bool NullYieldsToNull { get; private set; }

        public void Init()
        {
            this.Result = new StringBuilder(string.Empty);
            this.HasValue = false;
            this.IsNull = false;
        }

        public void Accumulate(SqlString stringval)
        {
            if (!this.HasValue)
            {
                if (stringval.IsNull)
                {
                    this.IsNull = true;
                }
                else if (stringval.IsNull)
                {
                }
                else
                {
                    this.Result.Append(stringval.Value);
                }

                this.Delimiter = ", ";
            }
            else if (stringval.IsNull)
            {
                this.IsNull = true;
            }
            else
            {
                if (!stringval.IsNull)
                {
                    this.Result.AppendFormat("{0}{1}", this.Delimiter, stringval.Value);
                }
            }

            this.HasValue = this.HasValue || !stringval.IsNull;
        }

        public void Merge(StringConcat group)
        {
            if (group.HasValue)
            {
                this.Accumulate(group.Result.ToString());
            }
        }

        public SqlString Terminate()
        {
            return this.IsNull ? SqlString.Null : this.Result.ToString();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(this.Result.ToString());
            writer.Write(this.Delimiter.Value);
            writer.Write(this.HasValue);
            writer.Write(this.NullYieldsToNull);
            writer.Write(this.IsNull);
        }

        public void Read(BinaryReader reader)
        {
            this.Result = new StringBuilder(reader.ReadString());
            this.Delimiter = new SqlString(reader.ReadString());
            this.HasValue = reader.ReadBoolean();
            this.NullYieldsToNull = reader.ReadBoolean();
            this.IsNull = reader.ReadBoolean();
        }
    }
}