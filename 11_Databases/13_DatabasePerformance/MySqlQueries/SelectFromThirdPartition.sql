SELECT *
FROM logs Partition (p6)
WHERE YEAR(Date) = 2002
-- Select from partition - 0.750 sec.