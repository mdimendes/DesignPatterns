// See https://aka.ms/new-console-template for more information
using Memento;

Console.Title = "Memento";

CommandManager commandManager = new();
IEmployeeManagerRepository repository = new EmployeeManagerRespoitory();

commandManager.Invoke(
    new AddEmployeetoManagerList(repository, 1, new Employee(111, "Kevin")));
repository.WriteDataStore();

commandManager.Undo();
repository.WriteDataStore();

commandManager.Invoke(
    new AddEmployeetoManagerList(repository, 1, new Employee(222, "Clara")));
repository.WriteDataStore();

commandManager.Invoke(
    new AddEmployeetoManagerList(repository, 2, new Employee(333, "Tom")));
repository.WriteDataStore();

commandManager.UndoAll();
repository.WriteDataStore();

Console.ReadKey();
