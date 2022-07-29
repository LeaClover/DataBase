// ID	Номер маршрута	Пункт назначения	Время начала	Время окончания	Транспорт ID
// ID	VIN-номер ТС	Водитель ID	Кондуктор ID	Состояние	Характеристика ID
// ID	Марка	Модель	Количество мест	Всего в парке	Топлииво
// ID	Фамилия	Имя	Отчество	Дата рождения	Пол	Статус	Права


// string text = "id;RouteNumber;FinalDestination;TimeBegin;TimeEnd;BusID;\n";
// string text = "id;vinNumber;DriverID;conductorID;Status;InfoID;\n";
// string text = "id;Mark;Model;Seats;TotalCars;Fuel;\n";
string text = "id;FirstName;LastName;Birthday;Sex;Status;\n";

int count = 10;
string[] sex = { "жен", "муж"};
// string[] model = { "Model_1", "Model_2", "Model_3", "Model_4", "Model_5" };
// string[] time2 = { "23:30", "00:15", "23:25", "00:05", "23:35" };
string [] status = { "Работает", "Уволен", "Временно не работает"};

Random random = new Random();
for (int id = 1; id <= count; id++)
{
    string fName = $"Имя_{id}";
    string lName = $"Фамилия_{id}";
    string birth = $"{id}.{id}.19{random.Next(18, 20)}";
    int license= random.Next(100000000, 1000000000);
    string sexX = sex[random.Next(sex.Length)];
    string statuS = status[random.Next(status.Length)];
    // string modelL = model[random.Next(model.Length)];
    // int seats = random.Next(30, 46);
    // int conductorID = random.Next(1, 20);
    // int totalCars = random.Next(3, 9);
    // string statusS = status[random.Next(status.Length)];
    text += $"{id};{fName};{lName};{birth};{sexX};{statuS};\n";
}

System.Console.WriteLine(text);
File.WriteAllText("output.csv", text);