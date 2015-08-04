namespace Cataclism
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CSharpConstructions
    {
        private List<string> loops;
        private List<string> methods;
        private List<string> ifStatements;

        public CSharpConstructions()
        {
            this.loops = new List<string>();
            this.methods = new List<string>();
            this.ifStatements = new List<string>();
        }

        public List<string> Methods
        {
            get
            {
                List<string> clonedList = this.methods.ToList();

                return clonedList;
            }
        }

        public List<string> Loops
        {
            get
            {
                List<string> clonedList = this.loops.ToList();

                return clonedList;
            }
        }

        public List<string> IfStatements
        {
            get
            {
                List<string> clonedList = this.ifStatements.ToList();

                return clonedList;
            }
        }

        public void AddLoop(string loopParameters)
        {
            this.methods.Add(loopParameters);
        }

        public void AddMethod(string methodParameters)
        {
            this.methods.Add(methodParameters);
        }

        public void AddIfStatement(string ifStatementCondition)
        {
            this.methods.Add(ifStatementCondition);
        }
    }
}