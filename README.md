
# Тестовое задание на должность .net разработчик

Backend для анализа данных пользователей из JSON. Принимает список активных пользователей от Node.js, обрабатывает их и возвращает статистику (имя, телефон, email, друзья, дружеские пары).

## Требования
- .NET Core SDK (6.0)
- Node.js (последняя версия)

## Запуск
1. Склонируйте репозиторий:
   ```
   git clone https://github.com/ваш-логин/TestController.git
   cd TestController
   ```
2. Запустите backend (C#):
   ```
   dotnet run --project TestController
   ```
3. Запустите frontend (Node.js):
   - Убедитесь, что `root.js` и `test.json` находятся в одной директории.
   - Выполните:
     ```
     node root.js
     ```
## Пример работы
![Code_s8jVt3423P](https://github.com/user-attachments/assets/118befa1-5783-4306-99dd-a6a41525ec95)

## Структура
- `/Controllers` — HTTP-контроллеры.
- `/Models` — Модели данных (`User`, `Friend`).
- `/Services` — Бизнес-логика обработки.
- `/Validators` — Валидация телефона и email.

## Формат ответа
```
Имя: Имя
Номер телефона: +1 (XXX) XXX-XXXX или "Ошибка"
Почта: email@domain.com или "Ошибка"
Количество друзей: N
Дружеские пары: Имя1 - Имя2 или "Отсутствуют"
```
