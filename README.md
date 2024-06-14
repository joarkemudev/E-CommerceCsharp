## Plataforma de Comercio Electrónico Simplificada EcomerceC#

## Descripción
Esta es una plataforma de comercio electrónico simplificada con funcionalidades básicas de gestión del catálogo de productos y gestión de pedidos.

## Arquitectura

- **Frontend**: Angular
- **Backend**: ASP.NET Core Web API
- **Base de Datos**: en mysql

## Requisitos

- Node.js
- .NET Core SDK

## Instalación

## Clonar el Repositorio: git clone https://github.com/your-repository/e-commerce-platform.git
   cd e-commerce-platform

## Crear la base de datos en mysql:
   CREATE DATABASE EcommerceDB;

## Crear las tablas en la base de datos EcommerceDB:
   CREATE TABLE `ecommercedb`.`product` (
     `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
     `name` VARCHAR(45) NOT NULL COMMENT '',
     `description` VARCHAR(60) NOT NULL COMMENT '',
     `price` DOUBLE NOT NULL COMMENT '',
     PRIMARY KEY (`id`)  COMMENT '');
   CREATE TABLE `ecommercedb`.`orders` (
     `id` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '',
     `total` DOUBLE NOT NULL COMMENT '',
     PRIMARY KEY (`id`)  COMMENT '');

### Frontend

1. Navega al directorio `ecommerce-frontend`:
   ```sh
   cd ecommerce-frontend
   npm install
   ng serve

### Backend
   *tener correctamente configurado el usuario y la contraseña en el archivo appsetting.json de cada     microsercicio

   *Navega al directorio del microservicio:cd ProductService
   *Ejecuta el servicio:dotnet run
   *Navega al directorio del microservicio:cd OrderService
   *Ejecuta el servicio:dotnet run

### Docker
   *Tener Docker instalado.
   *Ejecutar los Microservicios con Docker Compose: docker-compose up
   *Acceder a la Aplicación: Abra su navegador y vaya a http://localhost:4200/.