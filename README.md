# EPhratria

This project contains anothers project using GitHub submodules and this submodules are:
- ephratria-autenticacao: This project contains rules and implementation for ecommerce about user authentication when they're trying to do login in plataform then will be authenticate with your biometry (face recognize).
- ephratria-catalogo: This project contains rules and implementation for ecommerce about all products available in plataform and will implementation the part that the user create post and looking for products in post created before.
- ephratria-financeiro: This project contains rules and implementation for ecommerce about payment and received inside plataform, then this module is control the part the accountting of system and transaction between users.
- ephratria-frontend: This project contains all implemetation for ecommerce about graphic interface for users. 

At all projects we will use the workflow abouve:
- stagging: This branch is responsable for create new features, fix issues, then here we create, delete and change de repo.
- development: This branch is receveid pull request from **stagging** and in this branch we test the code in development enviroment
- homologation: This branch is receveid pull request from **development** and in this branch we test quality assurance of software.
- production: This branch is received pull request from **homologation** and in this branch we will be the continous integration and continous delivery in AWS plataform.

All the project will use containers to control enviroment the development, and will be the tool called Docker.
