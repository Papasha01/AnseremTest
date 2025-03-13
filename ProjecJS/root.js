// Для файлов используется библиотека fs для node.js, установлена на стенде
const fs = require("fs");
// Функция, которая обращается к серверу
// В аргумент функиции передаются значения типа объект
// Для запросов библиотека тоже подключена
function getAnalize(data) {
  const express = require("express"),
    app = express(),
    request = require("request");

  request.post(
    {
      url: "http://localhost:5222/api/Analize/GetAnalize",
      body: JSON.stringify(data), // Если хотите передавать сразу json из аргумента, уберите сериализатор
      headers: {
        "Content-type": "application/json; charset=UTF-8",
      },
    },
    (err, response, body) => {
      console.log(body);
      if (body) {
        createResponseFile(JSON.parse(body));
      }
    }
  );
}

function root() {
  fs.readFile("test.json", "utf8", (err, data) => {
    if (err) {
      console.error("Ошибка при чтении файла:", err);
      return;
    }

    try {
      const jsonData = JSON.parse(data);

      const activeUsers = jsonData.filter((user) => user.isActive === true);

      console.log("Отфильтрованные пользователи (isActive = true):");
      console.log(activeUsers);
      getAnalize(activeUsers);
    } catch (parseError) {
      console.error("Ошибка при парсинге JSON:", parseError);
    }
  });
}

root();
