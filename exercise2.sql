--1) ��������� ���������� �������, ���������� ����������.
SELECT COUNT( DISTINCT d.docnumber) as "count docs", COUNT(DISTINCT  d.store) as "count store"
from "document" d 

--2) ������� ������ ����� ������� � ����������� ���������� � ��������� �� �������
SELECT d.store  as "storeId", COUNT(*) as "count doc", extract('Month' from d.docdate) as "month"
FROM document d 
GROUP BY "month", d.store  

--3) �� ����� ������ ������� ������ �� ������, ������� ��������� ������ � ����� �� ������� (� ������ ������ ��������� ���������, �� ������ ���������, ��� �������� - � ������ �� ���������, �� ������� ������)
select sel.storeId as "store Id"
from
(SELECT d.store as storeId, COUNT(*) as countdoc, extract('Month' from d.docdate) as "month"
FROM document d 
GROUP BY storeId, "month") sel
GROUP BY sel.storeId
HAVING count(*) = 1