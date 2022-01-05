

/*

 1. Сделайте эмулятор устройства сканера. Он сканирует (берет данные из какого либо файла), 
производит фейковые данные о загрузке процессора и памяти.
Код должен быть прост, и дальнейшую работу стоит вести только с контрактами данного устройства. 
Разработать небольшую библиотеку, которая принимает от этого эмулятора байты, 
сохраняет в различные форматы и мониторит его состояние, записывая в какой-либо лог.
2 (*) Сделать реализацию псевдо-сканнера изображений в выбранной папке. "Сканер" должен 
отслеживать появление новых файлов с помощью объекта FileSystemWatcher, открывать и обрабатывать каким-либо образом изображения 
с помощью (на пример) библиотеки ImageSharp и сохранять результат в некотором выбранном формате.
3. (:Star) Сделать реализацию механизма формирования SQL-запроса на основе дерева выражения ExpressionTree.
4. (*) Сделать реализацию алгоритма дифференцирования математического выражения на основе ExpressionTree

 */

using asp.net.mvc_lesson5.Task1;


// Создание файла для PseudoScanera
FaceDataMachin faceDataMachin = new FaceDataMachin();

faceDataMachin.FaceDataMachinGenerator(@"H:\homeworkcnn10\asp.net.mvc_lesson5\asp.net.mvc_lesson5\FaceDataMachin.JSON", 100);

// имитация работы PseudoScanera

PseudoScanner pseudoScanner = new PseudoScanner();

IList <FaceData> faceData = pseudoScanner.ReadingPseudoScanner(@"H:\homeworkcnn10\asp.net.mvc_lesson5\asp.net.mvc_lesson5\FaceDataMachin.JSON");

pseudoScanner.ReadingConsolPseudoScanner();


// 