# Актуальная версия
https://github.com/immisterio/MatriX.API

# Установка
1. Установить ".NET Core 6" https://learn.microsoft.com/ru-ru/dotnet/core/install/
2. Загрузить и распаковать релиз https://github.com/immisterio/TSApi/releases в папку /opt/tsapi
3. Запустить "dotnet TSApi.dll -d=/opt/tsapi"

# Параметры
1. Настройки TSApi меняються в settings.json
2. Список пользователей редактируется в usersDb.json

# Crontab
```
*/5 *   *   *   *    curl -s "http://127.0.0.1:8090/cron/updateusersdb"
*   *   *   *   *    curl -s "http://127.0.0.1:8090/cron/checkingnodes"
```

# Запуск на домене
1. В settings.json ставим false для IPAddressAny
2. В /etc/nginx/sites-enabled кидаем nginx.conf

