select distinct extract('Year' from r."date") as "���", o."name" as "�����������", 
count(distinct r.personid) as "���-�� �������", count(r.nomk_ls) as "���-�� ��������", sum(r.sl_all) as "����� �������"
from recipes r 
inner join drug d on r.nomk_ls = d.nomk_ls
inner join "owner" o on r."owner" = o.id 
where (lower(d.name_med) like '%����-�������%' or lower(d.name_med) like '%�����%')
and o.id = 9 or (o.id >= 3 and o.id <= 8)
and r.nomk_ls < 1000
group by o.id, "���", o."name"