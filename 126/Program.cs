// Задание со звездочкой (домашнее)
// SELECT ФИО, Тел, Коммент FROM Люди LEFT JOIN Телефоны ON id = Чей телефон


select

pers_full_name,
tel_number,
tel_comm

from pers left join tel on pers.pers_id = tel.tel_id

// Выборка проведена в PostegreSQL, итог выборки - файл "Выборка"