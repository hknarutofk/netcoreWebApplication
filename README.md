# mysql反向工程

## 安装依赖

![image-20201111112527117](img\image-20201111112527117.png)

## 更新依赖数据库

![image-20201111112753801](img\image-20201111112753801.png)

## 执行反向工程指令


```
dotnet ef dbcontext scaffold "server=localhost;port=3306;database=sbtest;uid=root;pwd=abcDEF123___;CharSet=utf8mb4" Pomelo.EntityFrameworkCore.Mysql -f -o Models
```

## 生成结果

![image-20201111112941798](img\image-20201111112941798.png)