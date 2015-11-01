SELECT *
FROM logs Partition (p4)
WHERE YEAR(Date) = 1996
-- Select from partition - 0.625 sec.