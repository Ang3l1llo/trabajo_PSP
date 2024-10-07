// See https://aka.ms/new-console-template for more information
using Primerproyecto;

Console.WriteLine("Hello, World of DAM II!");

//TEST MANUALES

//comprobación de que se crean objetos
var character = new Character("Herculit");
var sword = new Sword("Short sword", 10);
var axe = new Axe("Bronze axe", 15);
var shield = new Shield("Aegis of steel", 15);
var helmet = new Helmet("Jagged helmet", 10);
var InvokerCane = new InvokerCane("Stick of wood with some magic", 5, 3);
var goblin = new Goblin();

//comprobación de que se invocan minions
InvokerCane.SummonMinion("Josue", 100, 50, 5);
InvokerCane.SummonMinion("Luis", 90, 40, 10);


Console.WriteLine("Manual Tests: ");

//comprobación de que se añaden al inventario
character.AddToInventory(sword);
character.AddToInventory(axe);
character.AddToInventory(shield);
character.AddToInventory(helmet);
character.AddToInventory(InvokerCane);

//comprobación de que se aplican al pj
sword.Apply(character);
shield.Apply(character);
helmet.Apply(character);
axe.Apply(character);

//comprobación de que le entra daño y se cura
character.RecieveDamage(31);
Console.WriteLine(character);

character.Heal(10);
Console.WriteLine(character);

//comprobación de que los minions invocados atacan
InvokerCane.OrderAttack(goblin);
Console.WriteLine(goblin);

