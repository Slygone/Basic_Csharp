//create an array of users and add 3 users to it manually(hard coded)

using Task3.Models;

User[] users = new User[3];
users[0] = new User(001,"Nikola","password","Here are your messages: Hi!");
users[1] = new User(002, "Aleksandar", "!password120%", "No new messages!");
users[2] = new User(003, "Stefan", "VeryHardPassword", "No new messages!");

users[0].Login("Nikola","password");