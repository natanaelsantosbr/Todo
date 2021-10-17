cd dev
md Todo
cd Todo
md Todo.Domain
<br/>md Todo.Domain.Tests
<br/>md Todo.Domain.Infra
<br/>md Todo.Domain.Api
<br/>ls
<br/>cd Todo.Domain
<br/>dotnet new classlib
<br/>cd..
<br/>cd Todo.Domain.Api
<br/>dotnet new webapi
<br/>cd..
<br/>cd Todo.Domain.Infra
<br/>dotnet new classlib
<br/>cd..
<br/>cd Todo.domain.tests
<br/>dotnet new mstest
<br/>ls
<br/>dotnet new sln
<br/>dotnet sln add .\Todo.Domain\
<br/>dotnet sln add .\Todo.Domain.Tests\
<br/>dotnet sln add .\Todo.Domain.Infra\
<br/>dotnet sln add .\Todo.Domain.Api\
<br/>cd .\Todo.Domain.Api\
<br/>dotnet add reference ..\Todo.Domain\
<br/>dotnet add reference ..\Todo.Domain.Infra\
<br/>cd..
<br/>cd .\Todo.Domain.Infra\
<br/>dotnet add reference ..\Todo.Domain\
<br/>cd..
<br/>cd .\Todo.Domain.Tests\
<br/>dotnet add reference ..\Todo.Domain\
<br/>cd..
<br/>dotnet new gitignore
