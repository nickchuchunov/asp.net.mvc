

/*

1. Используйте предыдущее домашнее задание с эмулятором сканера и по максимуму
переведите его на Autofac используя встроенный функционал паттернов и внедрения
зависимостей.

 */


 using asp.net.mvc_lesson6;


ActionAutofac  action = new ActionAutofac();



var  ActionHosting = action.Hosting;

ActionHosting.StartAsync();

