The database is stored in a [mysql workbench](https://www.mysql.com/products/workbench/) file

* LotsOfVideo.mwb

Download and install [mysql workbench](https://www.mysql.com/products/workbench/) to work with the database.

# Run SQL Server

```bash
docker run --name some-mysql -p 3306:3306 -v /my/own/datadir:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=my-secret-pw -d mysql:8 --character-set-server=utf8mb4 --collation-server=utf8mb4_unicode_ci
```

# Schema

ms_project2

Altertnatives include 
* [Azure MySQL hosted](https://azure.microsoft.com/en-ca/services/mysql/)
* AWS MySQL
