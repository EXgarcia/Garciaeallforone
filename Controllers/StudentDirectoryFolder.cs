using Microsoft.AspNetCore.Mvc;
using StudentDirectoryFolderApi.Models;

namespace GarciaEAllForOne.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentDirectoryFolderController : ControllerBase
{
    public List<StudentListModel> studentsList = new List<StudentListModel>()
    {
      new StudentListModel(){
            firstName = "Jeremy",
            lastName = "Lapham",
            slackName = "Muscle Baby",
            email = "jlapham@codestack.co",
            hobbies = "Body building, powerlifting, wrestling"
        },
           new StudentListModel(){
            firstName = "Brandon",
            lastName = "Le",
            slackName = "Brandon Le",
            email = "ble@codestack.co",
            hobbies = "Eating & Sleeping"
            },
            new StudentListModel(){
            firstName = "Jessie",
            lastName = "Lamzon",
            slackName = "Jessie Lamzon",
            email = "jlamzon@codestack.co",
            hobbies = "Eating, traveling"
            },
            new StudentListModel(){
            firstName = "Andrea",
            lastName = "Burr",
            slackName = "Andrea Burr",
            email = "aburr@codestack.co",
            hobbies = "Horse Riding"
            },
            new StudentListModel(){
            firstName = "Daniel",
            lastName = "Decoito",
            slackName = "Daniel Decoito",
            email = "DanielDecoito@gmail.com",
            hobbies = "bears, beets, battlestar galactica"
            },
            new StudentListModel(){
            firstName = "Pedro",
            lastName = "Castaneda",
            slackName = "Pedro Castaneda",
            email = "pcastaneda@codestack.co",
            hobbies = "hiking and traveling"
            },
            new StudentListModel(){
            firstName = "Jacob",
            lastName = "Dekok",
            slackName = "Jacob Dekok",
            email = "jdekok@codestack.co",
            hobbies = "Copying Jeremy, Body building, powerlifting, wrestling"
            },
            new StudentListModel(){
            firstName = "Kenneth",
            lastName = "Fujimura",
            slackName = "Kenneth Fujimura",
            email = "kfujimura@codestack.co",
            hobbies = "Games, Sports, Model Kits, Anime, Naps, Culinary Tourism"
            },
            new StudentListModel(){
            firstName = "Fernando",
            lastName = "Aguilar",
            slackName = "Freddy Aguilar",
            email = "faguilar@codestack.co",
            hobbies = "Playing video games, reading, writing"
            },
            new StudentListModel(){
            firstName = "Jovann",
            lastName = "Contreras",
            slackName = "Jovann Contreras",
            email = "jcontreras@codestack.co",
            hobbies = "Not filling out google spread sheets =/"
            },
            new StudentListModel(){
            firstName = "Andrew",
            lastName = "Nilsson",
            slackName = "Drew Nilsson",
            email = "anilsson@codestack.co",
            hobbies = "Playing video games"
            },
            new StudentListModel(){
            firstName = "Kent",
            lastName = "Tupas",
            slackName = "Kent Tupas",
            email = "kTupas@codestack.co",
            hobbies = "Anime"
            },
            new StudentListModel(){
            firstName = "Lerissa",
            lastName = "Lazar",
            slackName = "Lerissa Lazar",
            email = "llazar@codestack.co",
            hobbies = "Drawing & watching anime"
            },
            new StudentListModel(){
            firstName = "Madeline",
            lastName = "Gowan",
            slackName = "Maddie Gowan",
            email = "mgowan@codestack.co",
            hobbies = "Rodents"
            },
            new StudentListModel(){
            firstName = "N. Harrison",
            lastName = "Wilkins",
            slackName = "Harrison Wilkins",
            email = "nwilkins@codestack.co",
            hobbies = "Not filling out google spread sheets =/"
            },
            new StudentListModel(){
            firstName = "Manuel",
            lastName = "Leyva",
            slackName = "Manuel Leyva",
            email = "mleyva@codestack.co",
            hobbies = "Photography"
            },
            new StudentListModel(){
            firstName = "Elizar",
            lastName = "Garcia",
            slackName = "Elizar Garcia",
            email = "Egarcia@codestack.co",
            hobbies = "Bowling and Sleeping"
            },
            new StudentListModel(){
            firstName = "Mark",
            lastName = "Ramirez",
            slackName = "mark ramirez",
            email = "mramirez@codestack.co",
            hobbies = "games and drinking way too much water"
            },
            new StudentListModel(){
            firstName = "Chris",
            lastName = "Martinez",
            slackName = "Chris Martinez",
            email = "cmartinez@codestack.co",
            hobbies = "Playing Ping Pong"
            },
            new StudentListModel(){
            firstName = "Samuel",
            lastName = "Laguna",
            slackName = "Samuel Laguna",
            email = "slaguna@codestack.co",
            hobbies = "Not filling out google spread sheets =/"
            },
            new StudentListModel(){
            firstName = "Isaiah",
            lastName = "Ferguson",
            slackName = "Isaiah Ferguson",
            email = "IFerguson@codestack.co",
            hobbies = "Martial Arts, Tricking, Hiking, and Watching slice of life anime"
            },
            new StudentListModel(){
            firstName = "John",
            lastName = "Magpantay",
            slackName = "John Magpantay",
            email = "jmagpantay@codestack.co",
            hobbies = "FPS games"
            },
            new StudentListModel(){
            firstName = "Reed",
            lastName = "Goodwin",
            slackName = "Reed Goodwin",
            email = "rgoodwin@codestack.co",
            hobbies = "Not filling out google spread sheets =/"
            },
            new StudentListModel(){
            firstName = "Amar",
            lastName = "Mann",
            slackName = "Amar",
            email = "amann@codestack.co",
            hobbies = "Kicking rocks"
            },
            new StudentListModel(){
            firstName = "Marcel",
            lastName = "Rodriguez",
            slackName = "Marcel Rodriguez",
            email = "mrodriguez@codestack.co",
            hobbies = "Raves"
            },
            new StudentListModel(){
            firstName = "Richard",
            lastName = "Johnson",
            slackName = "Richard Johnson",
            email = "rjohnson@codestack.co",
            hobbies = "Watching youtube, sketching, playing video games"
            },
            new StudentListModel(){
            firstName = "Ulises",
            lastName = "Ortega",
            slackName = "Ulises Ortega",
            email = "uortega@codestack.co",
            hobbies = "Video Games, Rollerblading, Board Games"
            },
            new StudentListModel(){
            firstName = "Caroline",
            lastName = "Hana",
            slackName = "Caroline Hana",
            email = "chana@codestack.co",
            hobbies = "video games, anime, hanging out w friends"
            },
            new StudentListModel(){
            firstName = "Shaun",
            lastName = "Aguirre-Reyes",
            slackName = "saguirre-reyes",
            email = "saguirre-reyes@codestack.co",
            hobbies = "Writing, Listening to music"
            },
            new StudentListModel(){
            firstName = "Aisha",
            lastName = "Mashrah",
            slackName = "Aisha Mashrah",
            email = "amashrah@codestack.co",
            hobbies = "painting"
            },
            new StudentListModel(){
            firstName = "Griffin",
            lastName = "Parker",
            slackName = "Griffin Parker",
            email = "gparker@codestack.co",
            hobbies = "Singing, Reading, Playing Video Games"
            }
    };
    //endpont that gets a student by their first name
    [HttpGet]
    [Route("GetStudentByFirstName/{studentFirstName}")]

    public StudentListModel GetStudentByFirstName(string studentFirstName)
    {
        StudentListModel result = new StudentListModel();

        for(int i = 0; i < studentsList.Count; i++)
        {
            if(studentsList[i].firstName == studentFirstName)
            {
                result = studentsList[i];
                break;
            }else{
                result.firstName = "N/A";
                result.lastName = "N/A";
                result.slackName = "N/A";
                result.email = "N/A";
                result.hobbies = "N/A";
            }
        }
        return result;
     } 
     [HttpGet]
    [Route("GetStudentByLastName/{studentLastName}")]

    public StudentListModel GetStudentByLastName(string studentLastName)
    {
        StudentListModel result = new StudentListModel();

        for(int i = 0; i < studentsList.Count; i++)
        {
            if(studentsList[i].lastName == studentLastName)
            {
                result = studentsList[i];
                break;
            }else{
                result.firstName = "N/A";
                result.lastName = "N/A";
                result.slackName = "N/A";
                result.email = "N/A";
                result.hobbies = "N/A";
            }
        }
        return result;
     } 

     [HttpGet]
    [Route("GetStudentBySlackName/{studentSlackName}")]

    public StudentListModel GetStudentBySlackName(string studentSlackName)
    {
        StudentListModel result = new StudentListModel();

        for(int i = 0; i < studentsList.Count; i++)
        {
            if(studentsList[i].slackName == studentSlackName)
            {
                result = studentsList[i];
                break;
            }else{
                result.firstName = "N/A";
                result.lastName = "N/A";
                result.slackName = "N/A";
                result.email = "N/A";
                result.hobbies = "N/A";
            }
        }
        return result;
     } 

     [HttpGet]
    [Route("GetStudentByEmail/{studentEmail}")]

    public StudentListModel GetStudentByEmail(string studentEmail)
    {
        StudentListModel result = new StudentListModel();

        for(int i = 0; i < studentsList.Count; i++)
        {
            if(studentsList[i].email == studentEmail)
            {
                result = studentsList[i];
                break;
            }else{
                result.firstName = "N/A";
                result.lastName = "N/A";
                result.slackName = "N/A";
                result.email = "N/A";
                result.hobbies = "N/A";
            }
        }
        return result;
     } 
}

     
