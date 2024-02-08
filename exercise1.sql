select distinct extract('Year' from r."date") as "год", o."name" as "направление", 
count(distinct r.personid) as "кол-во человек", count(r.nomk_ls) as "кол-во упаковок", sum(r.sl_all) as "сумма отпуска"
from recipes r 
inner join drug d on r.nomk_ls = d.nomk_ls
inner join "owner" o on r."owner" = o.id 
where (lower(d.name_med) like '%тест-полоски%' or lower(d.name_med) like '%помпа%')
and o.id = 9 or (o.id >= 3 and o.id <= 8)
and r.nomk_ls < 1000
group by o.id, "год", o."name"