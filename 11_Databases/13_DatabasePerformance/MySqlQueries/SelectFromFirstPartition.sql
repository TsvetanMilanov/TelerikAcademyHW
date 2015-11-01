SELECT *
FROM logs Partition (p2)
WHERE YEAR(Date) = 1991
-- Select from partition - 0.375 sec.