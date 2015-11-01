CREATE TABLE logs(
  Id int NOT NULL AUTO_INCREMENT,
  Date date NOT NULL,
  Text nvarchar(500),
  PRIMARY KEY (Id, Date)
) PARTITION BY RANGE(YEAR(Date)) (
   PARTITION p0 VALUES LESS THAN (1990),
   PARTITION p2 VALUES LESS THAN (2000),
   PARTITION p4 VALUES LESS THAN (2010),
   PARTITION p6 VALUES LESS THAN (2030)
);


delimiter #

CREATE PROCEDURE `insertLogs`()
begin

declare v_max int unsigned default 1000000;
declare v_counter int unsigned default 0;

  start transaction;
  while v_counter < v_max do
    insert into logs(Date, Text) values (FROM_UNIXTIME(
        UNIX_TIMESTAMP('1990-01-01 14:53:27') + FLOOR(0 + (RAND() * 999072000))
    ), 'asdasdasdasdasffwrgergdfwe' + v_counter );
    set v_counter=v_counter+1;
  end while;
  commit;
end #

call insertLogs()