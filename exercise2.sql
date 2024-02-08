--1) Посчитать количетсво складов, количество документов.
SELECT COUNT( DISTINCT d.docnumber) as "count docs", COUNT(DISTINCT  d.store) as "count store"
from "document" d 

--2) Вывести список кодов складов с количеством документов с разбивкой по месяцам
SELECT d.store  as "storeId", COUNT(*) as "count doc", extract('Month' from d.docdate) as "month"
FROM document d 
GROUP BY "month", d.store  

--3) Из этого списка вывести только те склады, которые числились только в одном из месяцев (в первом месяце проводили документы, во втором перестали, или наоборот - в первом не проводили, со второго начали)
select sel.storeId as "store Id"
from
(SELECT d.store as storeId, COUNT(*) as countdoc, extract('Month' from d.docdate) as "month"
FROM document d 
GROUP BY storeId, "month") sel
GROUP BY sel.storeId
HAVING count(*) = 1