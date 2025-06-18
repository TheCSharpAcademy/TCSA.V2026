using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data.Curriculum;

public class CourseHelper
{
    public static List<Course> GetCourses()
    {
        return new List<Course>
        {
            new Course
            {
                Id = 1,
                Title = "Introduction to Object Oriented Programming",
                Description = "Learn the most used programming paradigm in web development!",
                ImgUrl = "icons8-architecture-64.png",
                Articles = new List<Article>
                {
                    new Article
                    {
                        Id = 500025,
                        CourseDisplayId = 0,
                        Title = "Introduction",
                        Slug = "oop-introduction",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "It's a pleasure to teach you Object Oriented Programming! Not only it's an elegant approach to software development, but it's especially nice in C#. You'll have a great time while learning powerful concepts in the context of a project!" },
                                }
                            },
                            new Block
                            {
                                Title = "Who's this course for?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "This course isn't for absolute beginners in C#. You'll struggle if you don't know basic topics such as basic C# syntax (variables, loops, methods, data types, basic data structures, control flow),  how to navigate Visual Studio or Visual Studio Code and how to create a console apps, to mention a few. If you're an absolute beginner, we recommend you go back to this article and build a solid foundation first." },
                                    new Paragraph {
                                       Body = "This course doesn't cover all topics in OOP. It's an Intro course. We will be releasing an advanced course within the next few weeks. However you will still benefit from this course if you have previous knowledge of OOP but not a lot of practice. If you have extensive professional experience, you might still be able to close some knowledge gaps." }
                                }
                            },
                            new Block
                            {
                                Title = "What We Recommend?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "<b>Study each chapter carefully</b>: Make quick notes with important observations and remaining doubts. Don't rush through things. Make sure you understand what each key word does. Ask follow-up questions from Chat GPT. Use it as an assistant. Its biggest strength is the ability to explain concepts in different ways in a conversational style." },
                                    new Paragraph {
                                       Body = "<b>Make Notes</b>: Using your preferred note-taking system, write down what you took from each chapter. What do you understand better? What topic is still not clear? Reflecting upon what you've learned is one of the best ways to retain knowledge." },
                                    new Paragraph {
                                       Body = "<b>Review the Code</b>: At the end of each practical chapter you'll find a <b>View Code</b> button, where you can see all of the project's code up to that point in the course. If you run into issues, compare your code to ours before asking for help. It could be a typo or somethign you forgot to add." }
                                }
                            },
                            new Block
                            {
                                Title = "Video Course",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We also have a paid video version of this tutorial. You have three options to access this course:<br><br>\r\n<b>Option 1</b>: Purchase the course <a href='https://thecsharpschool.getlearnworlds.com/payment?product_id=cshasp-object-oriented-programming-crash-course' target='_blank'>individually for $4.99</a>.<br>\r\n<b>Option 2</b>: Subscribe to the <b>VIP Membership</b> and have access to <a href='https://thecsharpschool.getlearnworlds.com/payment?product_id=the-c-academy-membership&type=subscription' target='_blank'>all our courses for $4.99/month</a><br>\r\n<b>Option 3</b>: Subscribe to the <b>VIP Mentorship</b> for <a href='https://thecsharpschool.getlearnworlds.com/payment?product_id=net-accelerator-mentorship&type=subscription' target='_blank'>all courses and 1-on-1 mentorship for 39.99/month</a>" },
                                }
                            },
                            new Block
                            {
                                Title = "Give Feedback",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "If you find any typos, broken links, misplaced or wrong information or any other issues, let us know! We're only humans and bound to making mistakes. Reach out on our Discord Community, using the #feedback channel. We appreciate your help!" },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500000,
                        CourseDisplayId = 1,
                        Title = "What Is OOP?",
                        Slug = "getting-started-with-csharp",
                        Description = "Learn the fundamentals of C# programming language.",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Welcome to the world of <b>Object-Oriented Programming (OOP)</b> in C#! Your programming life will never be the same. In this chapter, we'll explore what OOP is, why it's important, and how it makes your code more organized, readable, and maintainable. By the end of this course you'll be more confident in your coding skills and more prepared to tackle any software development project." },
                                    new Paragraph { Body = "Imagine you have two workshops. <b>One is clean and tidy</b>, with tools neatly arranged on shelves, labeled drawers for screws and nails, and a well-organized space where you can quickly find what you need. <b>The other is chaotic</b>, with tools scattered across the floor, screws mixed with nails in random boxes, and materials piled up in no particular order." },
                                    new Paragraph { Body = "Which workshop would you prefer to work in? The tidy one allows you to be more productive—you can easily locate your tools, everything has its place, and the space just makes sense. The messy workshop, on the other hand, <b>slows you down</b>. You waste time searching for what you need, and the chaos makes it harder to complete your projects efficiently." },
                                    new Paragraph { IsPicture = true, PictureUrl = "c1-ch1-oop-office.png"},
                                    new Paragraph { Body = "In OOP, you break down a complex problem into smaller, manageable parts. Each part is a \"tool\" that can be reused, improved, or replaced without affecting the entire program. With OOP, your projects become more scalable and easier to debug because you can pinpoint issues more quickly." },
                                    new Paragraph { Body = "In the chapters ahead, you'll learn how to use OOP principles in C# to create well-organized, clean, and efficient code. Just like in the tidy workshop, <b>everything will have its place</b>, making it easier for you to build and maintain your projects." }
                                }
                            },
                            new Block
                            {
                                Title = "If not OOP, Then What?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        Body = "Two alternatives to object-oriented programming (OOP) are <b>procedural </b> and <b> functional</b> programming. Functional programming emphasizes the use of <b>pure functions</b> and immutable data, focusing on the what of computation rather than the how. It encourages the use of functions as first-class citizens, allowing them to be passed around as arguments, returned from other functions, and stored in variables. Functional programming is particularly adept at <b>handling complex data transformations</b> and <b>concurrent programming</b>, as its immutable data structures eliminate issues related to shared state and side effects, making programs easier to reason about and test."
                                    },
                                    new Paragraph
                                    {
                                        Body = "In contrast, procedural programming <b>organizes code into procedures</b> that manipulate data through a series of step-by-step instructions. This approach typically involves a more imperative style, where the programmer explicitly defines the sequence of operations to be executed. While procedural programming can lead to straightforward implementations, it often struggles with scalability and maintainability in larger applications, as the tight coupling between data and procedures can lead to duplicated code and difficulty managing complexity. Object-oriented programming (OOP) addresses these issues by <b>encapsulating</b> data and behavior within objects. OOP facilitates code that is more intuitive and easier to maintain, as it <b>aligns closely with real-world concepts</b>, making it the most popular choice for many software development projects."
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500001,
                        CourseDisplayId = 2,
                        Title = "About this course",
                        Slug = "getting-started-with-csharp",
                        Description = "About this Cou",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In this course, we will be building a <b>Library Management System</b> to help demonstrate the concepts of Object-Oriented Programming (OOP) in C#. This project will serve as a practical, hands-on way to apply OOP principles and understand how they work in real-world scenarios." },
                                    new Paragraph { Body = "Learning OOP with theory alone can be difficult and abstract. It’s one thing to read about classes, objects, and inheritance, but it's another to actually use them to solve a real-world problem. That’s why building a project like the Library Management System is so important." }
                                }
                            },
                            new Block
                            {
                                Title = "Why Learn With Projects?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Projects provide context. They allow you to see how all the pieces fit together and how the concepts you learn are applied in actual coding tasks. A project:" },
                                    new Paragraph
{
    Body = @"
<ul>
    <li>➡️ <strong>Gives Purpose to Concepts:</strong> Rather than just memorizing definitions, you’ll see how classes, methods, and objects work together to form a functioning system.</li>
    <li>➡️ <strong>Encourages Problem Solving:</strong> When building a project, you’ll encounter challenges that force you to think critically and apply your knowledge.</li>
    <li>➡️ <strong>Develops Real-World Skills:</strong> By the end of the course, you won’t just understand OOP—you’ll have practical experience applying it to a full project.</li>
    <li>➡️ <strong>Boosts Confidence:</strong> Completing a project gives you something tangible to showcase, and it will boost your confidence as you see your progress.</li>
</ul>
"
},

                                    new Paragraph { Body = "The Library Management System will simulate a simplified library where you can manage books, magazines, and newspapers. The system will allow you to add, edit, and delete library items, view details of each item, keep track of different types of items (books, magazines, newspapers) with specific properties for each." }
                                }
                            },
                            new Block
                            {
                                Title = "Outcomes",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Through this project, you'll see how OOP allows us to:" },
                                    new Paragraph
{
    Body = @"
<ul>
    <li>➡️ Create reusable components (like different types of library items).</li>
    <li>➡️ Group related data and behavior into classes.</li>
    <li>➡️ Leverage inheritance to avoid repeating code.</li>
    <li>➡️ Use encapsulation to protect and manage data efficiently.</li>
</ul>
"
},
                                    new Paragraph { Body = "In the next chapters, we'll start small by creating classes for different types of library items and gradually expand the system to introduce more complex functionality. Along the way, you'll be applying OOP concepts such as classes, objects, inheritance, polymorphism, and more." },
                                    new Paragraph { Body = "By the end of this course, not only will you have a strong understanding of OOP, but you'll also have a complete Library Management System that you can continue to build upon." },
                                    new Paragraph { Body = "Let's get started! 🤓" },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500002,
                        CourseDisplayId = 3,
                        Title = "Creating the Course Project",
                        Slug = "oop-course-project",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Before we start learning OOP we need to build the course's project. Let's start by spinning up a Console app. If you've never created a console app before this course isn't for you. <a href='project/53/math-game' target='_blank'>We suggest you watch the tutorial in this article first</a>." }
                                }
                            },
                            new Block
                            {
                                Title = "Using the Command Line",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We recommend you create your project via the command line if you haven't tried it. <b>We need to get stronger at using the CLI</b>. Navigate to the directory where you want to create the project, using the cd command. For example:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "cd path/to/your/folder"
                                    },
                                    new Paragraph { Body = "Run the following command to create a new console app:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "dotnet new console -n TCSA.OOP.LibraryManagementSystem"
                                    },
                                    new Paragraph { Body = "Navigate into the new project directory:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "cd TCSA.OOP.LibraryManagementSystem"
                                    },
                                    new Paragraph { Body = "Open your project in Visual Studio by typing the name of the project followed by .csproj" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "TCSA.OOP.LibraryManagementSystem.csproj"
                                    },
                                    new Paragraph { Body = "Now let's install Spectre Console, an amazing library that makes the lives of developers much easier when working with Console apps. With Spectre we can provide a much better user experience without having to write a lot of code. To install it, use the following command in the CLI:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "dotnet add package Spectre.Console"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "First Lines Of Code",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Finally let's write some code to demonstrate the power of Spectre Console. In Program.cs, delete the Hello World Code and replace it with this snippet: " },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "var menuChoices = new string[3] { \"View Books\", \"Add Book\", \"Delete Book\" };\r\n\r\nvar choice = AnsiConsole.Prompt(\r\n        new SelectionPrompt&lt;string&gt;()\r\n        .Title(\"What do you want to do next?\")\r\n        .AddChoices(menuChoices));"
                                    },
                                    new Paragraph { Body = "Again if the above code is totally foreign to you, this course might not be the best suit for your current level. <a href='project/53/math-game' target='_blank'>We suggest you watch the tutorial in this article first</a>." },
                                    new Paragraph { Body = "Let's explain the code:" },
                                    new Paragraph
{
    Body = @"
<ul style='margin-bottom: 10px;'>
    <li style='margin-bottom: 10px;'>➡️ We're creating an <b>array of strings</b> that will serve as the menu choices. For now we'll only have three choices, but we'll expand it later. I'm creating the variable that stores this array using 'var' but it's up to you how you create it.</li>
    <li style='margin-bottom: 10px;'>➡️ Then we're using the <b>Prompt method</b> of the <b>AnsiConsole</b> class, from Spectre.Console namespace, to create the menu. We're prompting a <b>SelectionPrompt</b>. This class has a <b>Title method</b>, to which we're passing our desired menu title, and an <b>AddChoices method</b>, to which we're passing our array of choices. </li>
</ul>
"
},
                                     new Paragraph { Body = "Run the app and you'll see the menu. Use the arrows in your keyboard to select one of the choices. Isn't that cool? this means we will need to write much less validation code, since the menu choices are fixed." },

                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nvar menuChoices = new string[3] { \"View Books\", \"AddBook\", \"Delete Book\" };\r\n\r\nvar choice = AnsiConsole.Prompt(\r\n        new SelectionPrompt&lt;string&gt;()\r\n        .Title(\"What do you want to do next?\")\r\n        .AddChoices(menuChoices));"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500003,
                        CourseDisplayId = 4,
                        Title = "Basic Functionality",
                        Slug = "oop-course-project-functionality",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "I know you're looking forward to learning OOP, but we just have one more step before starting. Let's add some code to let the users view, add, and delete books." }
                                }
                            },
                            new Block
                            {
                                Title = "Global List of Books",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "At the top of the file, just <b>under menuChoices</b>, let's add a list of books. We won't be storing books in a database,  since it's out of the scope of this course:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "var books = new List&lt;string&gt;()\r\n{\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n};"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Menu Loop",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Next we need to make sure the menu runs again after an operation is completed. For this, just put it in a loop. Notice we're also clearing the console with the <b>Clear() method</b> to improve readability:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "while (true)\r\n{\r\n    Console.Clear();\r\n\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;string&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(menuChoices));\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Menu Choices Switch",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now, inside the loop, let's create a switch statement to handle each option. The switch statement will branch the execution of the code based on the <b>choice variable</b>." },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "while (true)\r\n{\r\n    Console.Clear();\r\n\r\n    // menu code here\r\n\r\n    switch (choice)\r\n    {\r\n        case \"View Books\":\r\n            break;\r\n        case \"Add Book\":        \r\n            break;\r\n        case \"Delete Book\":         \r\n            break;\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Implementing the Options",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Finally, let's add the code for each case. You can see the explanation about what the code is doing in the comment in the code block:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "case \"View Books\":\r\n    /* Spectre's MarkupLine method is useful for styling strings.\r\n    We'll use it as a standard do print messages to the console.*/\r\n    AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n    // Printing each book to the console with a loop\r\n    foreach (var book in books)\r\n    {\r\n        AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n    }\r\n\r\n    /* Having the user press a key before continuing, or the menu\r\n     wouldn't be visualisable */         \r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n\r\n    break;"
                                    },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "case \"Add Book\":\r\n    /* Spectre's Ask<> method allows us to prompt a message to grab \r\n     the user's input. We can pass the type we expect as an answer\r\n    for validation. We're storing the answer in the 'title' variable*/ \r\n    var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n    // checking if the book already exists to avoid duplication.\r\n    if (books.Contains(title))\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n    }\r\n    else\r\n    {\r\n        //if book doesn't exist, add to the list of books.\r\n        books.Add(title);\r\n        AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n    break;"
                                    },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "case \"Delete Book\":\r\n    // checking if there are any books to delete and letting the user know\r\n    if (books.Count == 0)\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n        Console.ReadKey();\r\n        return;\r\n    }\r\n\r\n    /* showing a list of books and letting the user choose with arrows \r\n     using SelectionPrompt, similarly to what we do with the menu */\r\n    var bookToDelete = AnsiConsole.Prompt(\r\n        new SelectionPrompt&lt;string&gt;()\r\n        .Title(\"Select a [red]book[/] to delete:\")\r\n        .AddChoices(books));\r\n\r\n    /* Using the Remove method to delete a book. This method returns a boolean\r\n      that we can use to present a message in case of success or failure.*/\r\n    if (books.Remove(bookToDelete))\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n    }\r\n    else\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n    break;"
                                    },
                                    new Paragraph
                                    {
                                        Body = "Next run the app. You should be able to view, add and delete books. We're ready to jump into OOP concepts!"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nvar menuChoices = new string[3] { \"View Books\", \"Add Book\", \"Delete Book\" };\r\nvar books = new List&lt;string&gt;()\r\n{\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n};\r\n\r\nwhile (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;string&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(menuChoices));\r\n\r\n    switch (choice)\r\n    {\r\n        case \"View Books\":\r\n            AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n            foreach (var book in books)\r\n            {\r\n                AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n\r\n            break;\r\n        case \"Add Book\":\r\n            var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n            if (books.Contains(title))\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n            }\r\n            else\r\n            {\r\n                books.Add(title);\r\n                AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n            break;\r\n        case \"MenuOption.DeleteBook\":\r\n            if (books.Count == 0)\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n                Console.ReadKey();\r\n                return;\r\n            }\r\n\r\n            var bookToDelete = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;string&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(books));\r\n\r\n            if (books.Remove(bookToDelete))\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n            }\r\n            else\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n            break;\r\n    }\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500004,
                        CourseDisplayId = 5,
                        Title = "Enumerations",
                        Slug = "object-oriented-enums",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Enums allow you to define a type that can only take one of a predefined set of values. This restricts the possible values a variable can hold, reducing errors. They're particularly suited for situations where we only have a small amount of options. " }
                                }
                            },
                            new Block
                            {
                                Title = "Creating an enum",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In our app, the menu options are a perfect use case for an enum. So let's create our first. At the end of the file, outside of the loop, add this snippet:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "enum MenuOption\r\n{\r\n    ViewBooks,\r\n    AddBook,\r\n    DeleteBook\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Using the Enum",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Next modify the code inside your switch statement so it looks like this. I'm supressing the code inside the switch statement cases to help readability: " },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "while (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.ViewBooks:\r\n            // view book code\r\n            break;\r\n        case MenuOption.AddBook:\r\n            // add book code\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            // delete book code\r\n            break;\r\n    }\r\n}"
                                    },
                                    new Paragraph
                                    {
                                        Body = "Our Selection Prompt is now of the \"MenuOption\" type, instead of string. We can extract the values of our Enum using the GetValues<>() method."
                                    },
                                     new Paragraph
                                    {
                                        Body = "We are now using the enumeration values as cases for our switch statement. For this we need to provide the qualified value, meaning the name of the type, and the name of the option (i.e. MenuOption.ViewBooks)"
                                    }
                                },
                            },
                            new Block
                            {
                                Title = "How does this fit in OOP?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "➡️ <b>Readability</b>: Using enums makes your code more expressive and easier to understand compared to using literal constants or integers." },
                                    new Paragraph { Body = "➡️ <b>Encapsulation</b>: Enums help encapsulate related constants within a single type, promoting better organization and abstraction in your codebase. We'll learn more about encapsulation later in this course. It's one of the core principles of OOP" },
                                }
                            },
                            new Block
                            {
                                Title = "Less Errors",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Additionally, using enums provide a safeguard against typos. Let's take our ViewBooks enum as an example. As a developer, I'd have to be precise when writing this reference elsewhere in the code. \"View Books\", \"Viewbooks\", \"viewbooks\" are all variations that could cause problems. I'd have to write extra code to prevent these errors. With enums, the compiler will help us with the correct value. In the fast-paced environment of enterprise development, such ease of use can't be neglected!" }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nvar books = new List&lt;string&gt;()\r\n{\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n};\r\n\r\nwhile (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.Viewbooks:\r\n            AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n            foreach (var book in books)\r\n            {\r\n                AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n\r\n            break;\r\n        case MenuOption.AddBook:\r\n            var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n            if (books.Contains(title))\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n            }\r\n            else\r\n            {\r\n                books.Add(title);\r\n                AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            if (books.Count == 0)\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n                Console.ReadKey();\r\n                return;\r\n            }\r\n\r\n            var bookToDelete = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;string&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(books));\r\n\r\n            if (books.Remove(bookToDelete))\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n            }\r\n            else\r\n            {\r\n                AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n            }\r\n\r\n            AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n            Console.ReadKey();\r\n            break;\r\n    }\r\n}\r\n\r\nenum MenuOption\r\n{\r\n    Viewbooks,\r\n    AddBook,\r\n    DeleteBook\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500005,
                        CourseDisplayId = 6,
                        Title = "Methods",
                        Slug = "object-oriented-methods",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "So far, all the logic for handling the various menu choices was directly inside the switch statement within the while loop. Let's make the code more aligned to OOP principles by moving it into methods. " },
                                    new Paragraph { Body = "Under the loop, but above the Enum, create the method with the code for Viewing Books: \r\n" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "void ViewBooks()\r\n{\r\n    AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n    foreach (var book in books)\r\n    {\r\n        AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}"
                                    },
                                    new Paragraph
                                    {
                                        Body = "The method can be void as it doesn't return data. Its implementation uses the books list, but we don't need to pass it as a parameter, since the scope of the list allows it to be accessed by any method within Program.cs."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Implement the Missing Methods",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Repeat the process with the other two menu options, creating a method for each. Then call the methods from your switch statement cases. The switch should look like this: " },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "while (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.Viewbooks:\r\n            ViewBooks();\r\n            break;\r\n        case MenuOption.AddBook:\r\n            AddBook();\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            DeleteBook();\r\n            break;\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Encapsulation",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Encapsulation is one of the fundamental principles of OOP. It involves bundling data and methods that operate on that data into a single unit, typically a class. We will learn about classes soon. For now all we need to know is that all of our code is inside the <b>Program class</b>. Hence the Program.cs file. " },
                                    new Paragraph
                                    {
                                        Body = "A helpful analogy is to think of Encapsulation as putting your valuables in a safe. In programming, it means keeping important data and the details of how things work hidden inside a \"box\" (like a class). Only certain parts of the code, in this case, methods, can interact with that data. This protects the data and makes sure it’s only changed or accessed in controlled ways. So, just like only someone with the key can open the safe, only specific parts of your program can access or modify the hidden data."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Further advantages in using methods in the context of OOP",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "➡️ It helps us enforce that each part of the code is responsible for only one thing. This way of thinking is the Single Responsibility Principle, one of the most important principles in software programming. It fits neatly within the idea of Separation of Concerns." },
                                    new Paragraph { Body = "➡️ It makes the code reusable. Whenever we need to execute one of those operations we can simple invoke that method, instead of repeating the code. This helps developers abide to the DRY principle." },
                                    new Paragraph { Body = "➡️ It makes the code more testable.  Isolating functionality into methods makes it much easier to write unit tests." }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nvar books = new List&lt;string&gt;()\r\n{\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n};\r\n\r\nwhile (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.Viewbooks:\r\n            ViewBooks();\r\n            break;\r\n        case MenuOption.AddBook:\r\n            AddBook();\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            DeleteBook();\r\n            break;\r\n    }\r\n}\r\n\r\nvoid ViewBooks()\r\n{\r\n    AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n    foreach (var book in books)\r\n    {\r\n        AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}\r\n\r\nvoid AddBook()\r\n{\r\n    var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n    if (books.Contains(title))\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n    }\r\n    else\r\n    {\r\n        books.Add(title);\r\n        AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}\r\n\r\nvoid DeleteBook()\r\n{\r\n    if (books.Count == 0)\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n        Console.ReadKey();\r\n        return;\r\n    }\r\n\r\n    var bookToDelete = AnsiConsole.Prompt(\r\n        new SelectionPrompt&lt;string&gt;()\r\n        .Title(\"Select a [red]book[/] to delete:\")\r\n        .AddChoices(books));\r\n\r\n    if (books.Remove(bookToDelete))\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n    }\r\n    else\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}\r\n\r\nenum MenuOption\r\n{\r\n    Viewbooks,\r\n    AddBook,\r\n    DeleteBook\r\n}"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500006,
                        CourseDisplayId = 7,
                        Title = "Classes",
                        Slug = "object-oriented-classes",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In C#, a class is a blueprint for creating objects. It defines a type by encapsulating data (fields) and behavior (methods) that an object will have. A class serves as a template from which you can instantiate objects, and each object created from the class is called an instance." },
                                    new Paragraph { Body = "Let's create our first. In Visual Studio's solution explorer, right click \"TCSA.OOP.LibraryManagement\", and choose Add, then Class. Name it BooksController. Click the code cleanup icon and add a semi-colon to the namespace so your class looks like this: " },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class BooksController\r\n{\r\n}"
                                    },
                                    new Paragraph
                                    {
                                        Body = "Notice that in the signature, this class has the \"internal\" keyword. This is an access modifier. We'll have a deeper look at these later. For now it will suffice to know that an internal class can be accessed by other parts of the same project."
                                    },
                                    new Paragraph
                                    {
                                        Body = "To better demonstrate OOP, let's start by adding the static keyword to it's signature. By marking a class as static, we're saying that we cannot create instances of it. Be patient, we will explain all of this soon."
                                    },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class BooksController\r\n{\r\n}"
                                    },
                                }
                            },
                            new Block
                            {
                                Title = "Using the New Class",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now move all methods from Program.cs intro the BooksController. This class will be responsible for handling books. Mark all of them as internal and static as well. " },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "internal static class BooksController\r\n{\r\n    internal static void ViewBooks()\r\n    {\r\n        // implementation\r\n    }\r\n\r\n    internal static void AddBook()\r\n    {\r\n        // implementation\r\n    }\r\n\r\n    internal static void DeleteBook()\r\n    {\r\n        // implementation\r\n    }\r\n\r\n}"
                                    },
                                     new Paragraph { Body = "You've probably noticed that the compiler is showing an error. The list of books can't be found. Let's also move that variable into this class. Put them just above the methods. Mark it as private (it can only be accessed from within the class) and static:\r\n" },
                                     new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "internal static class BooksController\r\n{\r\n  private static List&lt;string&gt; books = new()\r\n    {\r\n    // list items\r\n    };\r\n\r\n   // methods here\r\n\r\n}"
                                    },
                                }
                            },
                            new Block
                            {
                                Title = "Adjust Program.cs",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Finally, we need to address one more issue. Back in Program.cs, the methods can't be found, since they moved to another class. Let's call those methods by qualifying them with the name of the class they belong to. Your loop should now look like this:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem;\r\n\r\nwhile (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.Viewbooks:\r\n            BooksController.ViewBooks();\r\n            break;\r\n        case MenuOption.AddBook:\r\n            BooksController.AddBook();\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            BooksController.DeleteBook();\r\n            break;\r\n    }\r\n}"
                                    },
                                    new Paragraph { Body = "Notice we have 'using TCSA.OOP.LibraryManagementSystem;' on top of the file. We need that to tell the compiler where BooksController is coming from." },
                                    new Paragraph { Body = "Now our program still does the same thing but the code is slightly more organized. We have a dedicated class to handle books. And Program.cs is calling the methods in that class." },
                                    new Paragraph { Body = "We still have several questions to answer: What does static do? How about the access-modifiers? And how come we don't see the declaration of the Program class? The code in program.cs is running without any methods? We'll tackle these in the next chapters." },
                                },
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem;\r\n\r\nwhile (true)\r\n{\r\n    var choice = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;MenuOption&gt;()\r\n            .Title(\"What do you want to do next?\")\r\n            .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n    switch (choice)\r\n    {\r\n        case MenuOption.Viewbooks:\r\n            BooksController.ViewBooks();\r\n            break;\r\n        case MenuOption.AddBook:\r\n            BooksController.AddBook();\r\n            break;\r\n        case MenuOption.DeleteBook:\r\n            BooksController.DeleteBook();\r\n            break;\r\n    }\r\n}\r\n\r\nenum MenuOption\r\n{\r\n    Viewbooks,\r\n    AddBook,\r\n    DeleteBook\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class BooksController\r\n{\r\n    private static List&lt;string&gt; books = new()\r\n    {\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n    };\r\n\r\n    internal static void ViewBooks()\r\n    {\r\n        AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n        foreach (var book in books)\r\n        {\r\n            AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal static void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n        if (books.Contains(title))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            books.Add(title);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal static void DeleteBook()\r\n    {\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;string&gt;()\r\n            .Title(\"Select a [red]book[/] to delete:\")\r\n            .AddChoices(books));\r\n\r\n        if (books.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500007,
                        CourseDisplayId = 8,
                        Title = "Top-level Statements",
                        Slug = "c-sharp-top-level-statements",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Top-level statements in C# are a feature introduced in C# 9 that allow you to write a simpler, more concise version of your program, eliminating the need to explicitly define the Main method and the containing Program class. This feature is particularly useful for small applications, scripts, and beginner-friendly code samples where the ceremony of defining the Main method is unnecessary." },
                                    new Paragraph { Body = "When you use top-level statements, C# automatically generates the Main method for you under the hood. The compiler treats the code in the file as if it were inside a Main method. So, your code behaves just like it would in a traditional C# program, but you don't see the Main method because it's implied. " },
                                    new Paragraph { Body = "Let's see what our current code would look like without top-level statements:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    BooksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    BooksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    BooksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Behind the Scenes",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We have to remember that the job of the compiler is to translate the code that developers write into Intermediate Language (IL), before it's ultimately executed by the .NET runtime." },
                                    new Paragraph { Body = "Intermediate Language can be quite confusing and we don't want to mess with it right now, but it's worth taking a look at what IL looks like when the code above is translated:" },
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "// IL pseudo-representation\r\n.class public auto ansi beforefieldinit Program\r\n       extends [System.Runtime]System.Object\r\n{\r\n    .method public hidebysig static \r\n        void Main(string[] args) cil managed \r\n    {\r\n        // IL code corresponding to your explicitly defined Main method\r\n    }\r\n}"
                                    },
                                     new Paragraph { Body = "This is exactly the same code generated by top-level statements. The only difference is what the developers see. With top level statements, the Main method and Program.cs declaration are happening under-the-hood. In computer programming a common nick-name for this is \"syntactic sugar\"." },
                                     new Paragraph
                                    {
                                        Body = "So even before designing your first class and methods you were working inside a class and a method all along! "
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500008,
                        CourseDisplayId = 9,
                        Title = "Access Modifiers",
                        Slug = "object-oriented-access-modifiers",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Access modifiers control the visibility and accessibility of class members. In C#, access modifiers help enforce encapsulation, one of the core principles of OOP." },
                                    new Paragraph { Body = "They are keywords that specify the declared accessibility of types and type members. They determine whether other parts of the code can access a particular class, method, property, or field. By controlling access, developers can protect the internal state of objects, exposing only necessary components. C# provides several access modifiers, each offering a different level of accessibility. " }
                                }
                            },
                            new Block
                            {
                                Title = "C# Acess Modifiers",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "➡️ <b>Public</b>: It's the most accessible modifier, allowing members to be accessed from any part of the code in the same assembly or from other assemblies. It ensures that the member is available to all." },
                                   new Paragraph { Body = "➡️ <b>Private</b>: It's the most restrictive modifier, limiting access to the containing class only. Members marked as private cannot be accessed from outside the class, ensuring full encapsulation of the class's implementation details." },
                                    new Paragraph { Body = "➡️ <b>Protected</b>: Allows access within the containing class and any class that inherits from it. This modifier is useful when you want derived classes to access certain members but still restrict access from the outside." },
                                   new Paragraph { Body = "➡️ <b>Internal</b>: Limits access to the current assembly, meaning that any type or member marked as internal can only be accessed by other types within the same project but not by other assemblies." },
                                    new Paragraph { Body = "➡️ <b>Protected Internal</b>: It's a combination of protected and internal, allowing access either from within the same assembly or from a derived class in another assembly. It offers flexibility when sharing access across inheritance hierarchies and assemblies." },
                                   new Paragraph { Body = "➡️ <b>Private protected</b>: It's the most restrictive of all inheritance-access modifiers, allowing access only from within the containing class or types derived from the class but only within the same assembly. This ensures that members are not exposed to derived classes from other assemblies." },
                                },
                            },
                            new Block
                            {
                                Title = "Best Practices",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "➡️ <b>Default to the Least Permissive Access</b>: Start with the most restrictive access level (private) and only increase accessibility when necessary. This minimizes unintended interactions and enhances security." },
                                   new Paragraph { Body = "➡️ <b>Use private for Implementation Details</b>: Keep fields and helper methods private unless there’s a clear need for broader access." },
                                    new Paragraph { Body = "➡️ <b>Expose Only Necessary Members</b>: Public members should represent the intended interface of the class. Avoid exposing internal workings unless required for extension or interaction." },
                                   new Paragraph { Body = "➡️ <b>Leverage internal for Assembly-Wide Access</b>: Use internal when members need to be accessible across multiple classes within the same assembly but should remain hidden from external assemblies." },
                                    new Paragraph { Body = "➡️ <b>Document Access Levels</b>: Clearly document the intended use and access levels of class members to aid maintainability and clarity for other developers." }
                                },
                            },
                            new Block
                            {
                                Title = "Default Access Modifier",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "If you don't explicitly declare an access modifier in C#, the default is private for members (fields, methods, properties) inside a class. This means that these members will only be accessible from within the same class or struct. For top-level types (such as classes, interfaces, or structs), the default access modifier is internal, making the type accessible only within the same assembly." }
                                },
                            },
                            new Block
                            {
                                Title = "Compiler Help",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "While we learn about access modifiers, we can count on the compiler's help. It will notify you with an error if you try to use an access modifier in a context where it is not allowed. For example, you cannot apply the private or protected modifier to a class. You also can't invoke a private method from outside of its class. In this case the compiler provides clear error messages to guide you." }
                                },
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500009,
                        CourseDisplayId = 10,
                        Title = "Creating More Classes",
                        Slug = "object-oriented-more-classes",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now that we have a better understand of access modifiers and of what's happening in Program.cs, let's create a few more classes. Start by creating UserInterface.cs, with a method where the main menu will live: \r\n" },
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static TCSA.OOP.LibraryManagement.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagement;\r\n\r\ninternal class UserInterface\r\n{\r\n    internal static void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            //menu code here:\r\n        }\r\n    }\r\n}" },
                                     new Paragraph { Body = "Notice that this time the class isn't static, but the method is. This is just to illustrate that it's possible to have static methods inside non-static classes." },
                                }
                            },
                            new Block
                            {
                                Title = "Enums Class",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Let's proceed by creating an Enums.cs class. It'll contain any enum we need to create for our app. " },
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "internal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}" },
                                   new Paragraph { Body = "Here we don't have to worry about the static keyword. Enums are types that allow you to directly access their members without instantiation. This is because enum members are <b>implicitly static</b> in nature, even if the enum itself is not static." },
                                    new Paragraph { Body = "You're probably asking yourself why we're using the word static a lot, without going deeper into it. There's a reason for that. We will clarify everything in the next couple of chapters." }
                                },
                            },
                            new Block
                            {
                                Title = "Starting Point",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The final step is to remove all code from Program.cs. From now on, it will serve as the starting point for our app:" },
                                   new Paragraph {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface.MainMenu();" },
                                   new Paragraph { Body = "These modifications improved the readability of our code. It's now neatly separated in four classes, following the Separation of Concerns simple." }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface.MainMenu();"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class BooksController\r\n{\r\n    private static List&lt;string&gt; books = new()\r\n    {\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n    };\r\n\r\n    internal static void ViewBooks()\r\n    {\r\n        AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n        foreach (var book in books)\r\n        {\r\n            AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal static void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n        if (books.Contains(title))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            books.Add(title);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal static void DeleteBook()\r\n    {\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;string&gt;()\r\n            .Title(\"Select a [red]book[/] to delete:\")\r\n            .AddChoices(books));\r\n\r\n        if (books.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    internal static void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                    new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    BooksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    BooksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    BooksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500010,
                        CourseDisplayId = 11,
                        Title = "Objects",
                        Slug = "object-oriented-objects",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The Object Oriented paradigm lies on the creation of objects. Classes are blueprints for the creation of objects. Let's use Program.cs as a sandbox for better understanding what it means. Replace the code we currently have with this: " },
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "class Car()\r\n{\r\n    internal string name;\r\n\r\n    internal void PrintName()\r\n    {\r\n        Console.WriteLine($\"I'm a {name}\");\r\n    }\r\n}" },
                                }
                            },
                            new Block
                            {
                                Title = "Members",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Proceed by adding a few lines of code above this class declaration. Program.cs now should look like this:" },
                                     new Paragraph {
                                        IsCode = true,
                                        Body = "﻿using TCSA.OOP.LibraryManagement;\r\n\r\n// UserInterface.MainMenu();\r\n\r\nCar car1 = new Car();\r\nCar car2 = new Car();\r\n\r\ncar1.name = \"Ferrari\";\r\ncar2.name = \"BMW\";\r\n\r\ncar1.PrintName();\r\ncar2.PrintName();\r\n\r\nclass Car()\r\n{\r\n    internal string name;\r\n\r\n    internal void PrintName()\r\n    {\r\n        Console.WriteLine($\"I'm a {name}\");\r\n    }\r\n}" },
                                    new Paragraph {
                                        Body = "Here's what's happening: We're using the new keyword to create objects (instances )of the car class. We're assigning names to both instances. We're invoking the PrintName method for both instances." },
                                   new Paragraph { Body = "If you run the app you'll see both names printed. This means the same blue print was used to create two different objects." }
                                },
                            },
                            new Block
                            {
                                Title = "Objects are Powerful",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "To illustrate the power of this concept, let's suppose we have a gigantic application where thousands of instances of Car get created across millions of lines of code. If we decide that every time we print a car's name it has to be upper case, we need to add one line of code to the method and all instances will be modified." },
                                   new Paragraph {
                                        IsCode = true,
                                        Body = "internal void PrintName()\r\n{\r\n    name = name.ToUpper();\r\n    Console.WriteLine($\"I'm a {name}\");\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using STUDY.OOP.LibraryManagement;\r\n\r\n// UserInterface.MainMenu();\r\n\r\nCar car1 = new Car();\r\nCar car2 = new Car();\r\n\r\ncar1.name = \"Ferrari\";\r\ncar2.name = \"BMW\";\r\n\r\ncar1.PrintName();\r\ncar2.PrintName();\r\n\r\nclass Car()\r\n{\r\n    internal string name;\r\n\r\n    internal void PrintName()\r\n    {\r\n        Console.WriteLine($\"I'm a {name}\");\r\n    }\r\n}"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500011,
                        CourseDisplayId = 12,
                        Title = "Static",
                        Slug = "object-oriented-static",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "So we talked about how objects are instances of classes. It's time to understand what static does." },
                                    new Paragraph {
                                        Body = "The main idea to keep in mind is that a class or a member of a class marked as static cannot be instantiated. Whenever we create a new object, it gets used and disposed of in memory after it does its job. That's not the same with static. Anything marked with static will live for the entire lifecycle of the app." },
                                }
                            },
                            new Block
                            {
                                Title = "Why not just make everything static?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "It's a valid question. It's definitely a possible approach, albeit a bad one. By making everything static our application essentially becomes procedural. If every method or class lives for the entire lifetime of the app, we are giving up on leveraging OOP for organization and maintainability." },
                                     new Paragraph {
                                        Body = "The biggest danger with static is that it creates <b>Global State</b>: data that can be accessed from anywhere within the code. As your application grows, this increases the chances of unexpected behaviors. One part of the app might be using that data without knowing how another area is using that same data. Static can be a threat to data integrity." }
                                }
                            },
                            new Block
                            {
                                Title = "So why use it at all?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Despite the danger, static has a place. Sometimes it doesn't make sense to create instances of a class. A good example can be found in the .NET class library itself, with a class we use all the time: " },
                                   new Paragraph {
                                        Body = "In BooksController.Viewbooks, right click on Console (at the bottom of the method and choose View Implementation). You'll see several fields and methods, including Clear, WriteLine an Readline, just to mention some of the most common:" },
                                     new Paragraph {
                                        Body = "In our app, it doesn't make sense to create a new List of books every time, we need the books to persist across time, so we can make it static. " },
                                     new Paragraph {
                                        Body = "It's not always obvious when to use the static keyword, but hopefully you're now better equipped to make those decisions! From here, the best way to find out will be in the real world, with practice. " },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500012,
                        CourseDisplayId = 13,
                        Title = "Practicing With Objects",
                        Slug = "object-oriented-practice",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now that we know about objects and the static classes, let's use these concepts in our app. Start by removing all instances of the static keyword from our code. In visual studio you can do a search with Ctrl + Shift + H and choosing Find In Files > Entire Solution." }
                                }
                            },
                            new Block
                            {
                                Title = "Mock Database",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Next let's create a static MockDatabase class. Since we need our list of books to persist, we'll make it a global variable, available to be used anywhere at anytime. This class will contain a static List&lt;string&gt; field." },
                                     new Paragraph {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;string&gt; Books = new()\r\n    {\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n    };\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "Books Controller",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Next, in the BooksController class we need to adjust the code so it uses the Books field in the Mockdatabase class. Here's how it's done in the ViewBooks method. Adjust the remaining accordingly:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = " internal void ViewBooks()\r\n {\r\n     AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n     foreach (var book in MockDatabase.Books)\r\n     {\r\n         AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n     }\r\n\r\n     AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n     Console.ReadKey();\r\n }" }
                                }
                            },
                             new Block
                            {
                                Title = "User Interface",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We can no longer directly access members of BooksController since it's not static. We now need to create an instance of it. In the UserInterface class, create a booksController field, just above the main menu:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class UserInterface\r\n{\r\n    private BooksController booksController = new BooksController();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        //menu code\r\n    } \r\n}" },
                                    new Paragraph { Body = "Then adjust the code in the switch statement so it uses the newly created field." },
                                }
                            },
                             new Block
                            {
                                Title = "Program.cs",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Finally, in Program.cs, create an instance of the UserInterface class and call MainMenu() method. This code will kick-start the application." },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n" },
                                   new Paragraph { Body = "After creating the basic functionality of the app, we spent several chapters merely refactoring our app applying new concepts. Although the program still does the exact same thing, our code is much more organized and maintainable following OOP principles!" },
                                }
                            },
                             new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class BooksController\r\n{\r\n    internal void ViewBooks()\r\n    {\r\n        AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n        foreach (var book in MockDatabase.Books)\r\n        {\r\n            AnsiConsole.MarkupLine($\"- [cyan]{book}[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n\r\n        if (MockDatabase.Books.Contains(title))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            MockDatabase.Books.Add(title);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void DeleteBook()\r\n    {\r\n        if (MockDatabase.Books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;string&gt;()\r\n            .Title(\"Select a [red]book[/] to delete:\")\r\n            .AddChoices(MockDatabase.Books));\r\n\r\n        if (MockDatabase.Books.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private BooksController booksController = new BooksController();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                    new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    booksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    booksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    booksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;string&gt; Books = new()\r\n    {\r\n    \"The Great Gatsby\", \"To Kill a Mockingbird\", \"1984\", \"Pride and Prejudice\", \"The Catcher in the Rye\", \"The Hobbit\", \"Moby-Dick\", \"War and Peace\", \"The Odyssey\", \"The Lord of the Rings\", \"Jane Eyre\", \"Animal Farm\", \"Brave New World\", \"The Chronicles of Narnia\", \"The Diary of a Young Girl\", \"The Alchemist\", \"Wuthering Heights\", \"Fahrenheit 451\", \"Catch-22\", \"The Hitchhiker's Guide to the Galaxy\"\r\n    };\r\n}"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500013,
                        CourseDisplayId = 14,
                        Title = "Tuples",
                        Slug = "object-oriented-tuples",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In C#, tuples are lightweight data structures that allow you to store a sequence of elements of different types. They are particularly useful for returning multiple values from a method without having to define a separate class or struct. Introduced in C# 7.0, tuples have evolved to become more powerful and user-friendly, especially with the introduction of <b>value tuples</b>." }
                                }
                            },
                            new Block
                            {
                                Title = "Creating a Tuple",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In Program.cs, comment out the current code and run the app with this snippet:" },
                                     new Paragraph {
                                        IsCode = true,
                                        Body = "(string, int) book1 = (\"Frankenstein\", 350);\r\nConsole.WriteLine($\"Title: {book1.Item1}, Pages: {book1.Item2}\");" },
                                      new Paragraph { Body = "In the first line, a tuple is created to represent a book with two pieces of information: the title and the number of pages. Here, (string, int) defines the types of the tuple elements. The variable book1 is assigned the tuple (\"Frankenstein\", 350), grouping these two related values into a single data structure. This approach allows you to handle multiple related values without creating a separate class." },
                                      new Paragraph { Body = "The second line demonstrates how to access and display the elements of the tuple. book1.Item1 retrieves the first element of the tuple, and book1.Item2 retrieves the second." },
                                }
                            },
                            new Block
                            {
                                Title = "Named Tuples",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Let's enhance the original code by using named tuples, which provide more clarity and improve code readability by assigning meaningful names to each element of the tuple." },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "(string Title, int Pages) book1 = (\"Frankenstein\", 350);\r\n\r\nConsole.WriteLine($\"Title: {book1.Title}, Pages: {book1.Pages}\");" }
                                }
                            },
                             new Block
                            {
                                Title = "The Downside",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We could go on and refactor our app to use tuples as representation of the books. However, it's likely a book will have many more properties. All of the sudden we could be faced with a monstrosity such as:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "(string Title, int Pages, string Author, string ISBN, string Publisher, int PublicationYear, string Genre, double Rating, bool IsAvailable, decimal Price) book1 = (\"Frankenstein\", 350, \"Mary Shelley\", \"123-4567890123\", \"Penguin Classics\", 1818, \"Gothic\", 4.5, true, 19.99m);" },
                                   new Paragraph { Body = "Not very readable at all. Tuples are much stronger when used more transiently, such as when returning a couple of values from methods where it doesn't really make sense to create a custom type. In the next few chapters we will learn a better approach." },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500014,
                        CourseDisplayId = 15,
                        Title = "Constructors",
                        Slug = "object-oriented-constructors",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Constructors are a key feature of OOP. They are special methods that run when an object is instantiated and ensure we can create objects setting their initial state." }
                                }
                            },
                            new Block
                            {
                                Title = "Book.cs",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In a new file, create a class called Book.cs:" },
                                     new Paragraph {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Book\r\n{\r\n    string Name;\r\n    int Pages;\r\n\r\n    internal Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n        Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n}" },
                                      new Paragraph { Body = "This class has a couple of fields and a special method that doesn't have a return type in its signature. This type of method is called a Constructor. In this case our constructor has a signature with two parameters. In its code block we're assigning the fields to the these parameters and printing them to the console" }
                                }
                            },
                            new Block
                            {
                                Title = "Calling Constructors",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In Program.cs, replace the current code with this snipper and run the app:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nvar book1 = new Book(\"Hamlet\", 200);\r\nvar book2 = new Book(\"Great Gatsby\", 300);" },
                                   new Paragraph { Body = "If you put a breakpoint in the constructor, you'll see that, just as any other method, it executes its code block. The difference is that it will run at the moment of initialization of that object." },
                                }
                            },
                             new Block
                            {
                                Title = "Default Constructor",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "If we don't explicitly declare a constructor, the compiler will create one behind the scenes. However if we declare a constructor with parameters and we still want to allow our class to be instantiated without arguments, we need to declare it explicitly." },
                                    new Paragraph { Body = "Right now if we try to initiate a class without arguments we get a compiler error. Try it yourself and see what happens:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nvar book1 = new Book(); //compiler error" },
                                }
                            },
                             new Block
                            {
                                Title = "Parameterless Constructor",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "So let's modify Book.cs, adding a parameterless constructor:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class Book\r\n{\r\n    string Name;\r\n    int Pages;\r\n\r\n    internal Book()\r\n    {\r\n        Name = \"Unknown\";\r\n        Pages = 0;\r\n    }\r\n\r\n    internal Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n        Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n}" },
                                   new Paragraph { Body = "Now we can create Books without passing arguments." },
                                }
                            },
                             new Block
                            {
                                Title = "Constructor Overload",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We can go a step further and allow Books to be created without a title. This technique is called constructor overload. We can create as many constructors as we need, provided they have different signatures." },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class Book\r\n{\r\n    string Name;\r\n    int Pages;\r\n\r\n    internal Book()\r\n    {\r\n        Name = \"Unknown\";\r\n        Pages = 0;\r\n      Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n\r\n    internal Book(int pages)\r\n    {\r\n        Name = \"Unknown\";\r\n        Pages = pages;\r\n        Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n\r\n    internal Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n        Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n}" },
                                   new Paragraph { Body = "Now we can create Books without passing arguments." },
                                }
                            },
                             new Block
                            {
                                Title = "Skipping Constructors",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We could initialize fields this way:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class Book\r\n{\r\n    string Name = \"Unknown\"\r\n    int Pages = 0;\r\n\r\n    internal Book(int pages)\r\n    {\r\n        Name = \"Unknown\";\r\n        Pages = pages;\r\n        Console.WriteLine($\"Name: {Name}, Pages = {Pages}\");\r\n    }\r\n}" },
                                   new Paragraph { Body = "This code would run before any constructors, which means that the assigned values would become default for these fields. However these values can be overridden by the constructors." },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500015,
                        CourseDisplayId = 16,
                        Title = "Properties",
                        Slug = "object-oriented-properties",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In C#, properties are a way to expose class fields in a controlled manner. They allow you to define how the fields of a class can be accessed and modified from outside the class. By using properties, you can implement encapsulation, which is one of the key principles of object-oriented programming. This means you can restrict direct access to the class fields and provide methods for reading and writing their values." }
                                }
                            },
                            new Block
                            {
                                Title = "Getters and Setters",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Getters and setters are methods associated with properties. A getter is a method that retrieves the value of a property, while a setter is a method that sets or updates the value of a property. This allows you to add logic during the retrieval or assignment of values, such as validation or logging, without exposing the underlying field directly." },
                                     new Paragraph {
                                        Body = "In the early versions of C#, specifically C# 1.0 released in 2002, properties were implemented using traditional methods. For example, you would have private fields to store the values, and you would define separate methods to get and set those values. In a class like Book, you might see something like this:" },
                                      new Paragraph {
                                          IsCode = true,
                                          Body = "internal class Book\r\n{\r\n    private string name;\r\n    private int pages;\r\n\r\n    public string GetName()\r\n    {\r\n        return name;\r\n    }\r\n\r\n    public void SetName(string value)\r\n    {\r\n        name = value;\r\n    }\r\n\r\n    public int GetPages()\r\n    {\r\n        return pages;\r\n    }\r\n\r\n    public void SetPages(int value)\r\n    {\r\n        pages = value;\r\n    }\r\n}\r\n" }
                                }
                            },
                            new Block
                            {
                                Title = "Property Syntax",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Starting with C# 2.0, properties became much easier to use with the introduction of the property syntax. Instead of creating separate getter and setter methods, you could define properties directly within the class. For the Book class, it would look like this:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class Book\r\n{\r\n    public string Name { get; set; }\r\n    public int Pages { get; set; }\r\n}" }
                                }
                            },
                             new Block
                            {
                                Title = "Auto-properties",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The evolution continued with the introduction of auto-properties in C# 6.0. With auto-properties, you could initialize properties directly in the declaration without needing to define a backing field at all. Here's how the Book class would look using auto-properties:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal class Book\r\n{\r\n    public string Name { get; set; } = \"Default Name\";\r\n    public int Pages { get; set; } = 100;\r\n}\r\n" },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500016,
                        CourseDisplayId = 17,
                        Title = "Models",
                        Slug = "object-oriented-models",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The Book class we've created in the previous chapter is commonly called a model. A class designed modeling a real-world object. With this we can introduce another OOP principle:" }
                                }
                            },
                            new Block
                            {
                                Title = "Abstraction",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Abstraction in OOP refers to creating a simplified model that represents only the essential features of an object while ignoring irrelevant details. It allows you to focus on what an object is and does at a high level, without worrying about the inner workings. For instance, when you model a Book in your class, you're focusing on attributes like Name and Pages, which are relevant for your application, while ignoring more intricate details like how the book is printed or how the paper is made. In this sense, abstraction helps you create a manageable, conceptual model of a real-world entity." },
                                     new Paragraph {
                                        Body = "This concept is closely related to the Encapsulation principle we've learned previously. To recap: Encapsulation, on the other hand, focuses on bundling the data (attributes) and methods that operate on that data within a single unit (the class) and restricting access to some of that data." }
                                }
                            },
                            new Block
                            {
                                Title = "Applying Model",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Let's apply our newly created model to our Library system. If you haven't yet, modify Book.cs so it uses auto-properties" },
                                   new Paragraph {
                                       IsCode = true,
                                       Body = "internal class Book\r\n{\r\n    public string Name { get; set; } = \"Unknown\";\r\n    public int Pages { get; set; } = 0;\r\n\r\n    public Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n    }\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "List of Books",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now let's apply it to our MockDatabase class, where we'll now have a list of the Book type instead of string." },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = " internal static class MockDatabase\r\n    {\r\n        internal static List&lt;Book&gt; Books = new()\r\n        {\r\n            new Book(\"The Great Gatsby\", 180),\r\n            new Book(\"To Kill a Mockingbird\", 281),\r\n            new Book(\"1984\", 328),\r\n            new Book(\"Pride and Prejudice\", 432),\r\n            new Book(\"The Catcher in the Rye\", 277),\r\n            new Book(\"The Hobbit\", 310),\r\n            new Book(\"Moby-Dick\", 585),\r\n            new Book(\"War and Peace\", 1225),\r\n            new Book(\"The Odyssey\", 400),\r\n            new Book(\"The Lord of the Rings\", 1178),\r\n            new Book(\"Jane Eyre\", 500),\r\n            new Book(\"Animal Farm\", 112),\r\n            new Book(\"Brave New World\", 268),\r\n            new Book(\"The Chronicles of Narnia\", 768),\r\n            new Book(\"The Diary of a Young Girl\", 283),\r\n            new Book(\"The Alchemist\", 208),\r\n            new Book(\"Wuthering Heights\", 400),\r\n            new Book(\"Fahrenheit 451\", 158),\r\n            new Book(\"Catch-22\", 453),\r\n            new Book(\"The Hitchhiker's Guide to the Galaxy\", 224)\r\n        };\r\n    }" },
                                }
                            },
                            new Block
                            {
                                Title = "The Controller",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "These modifications require several changes in BooksController: Modify ViewBooks(), so it uses the model's properties." },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = " internal void ViewBooks()\r\n{\r\n    AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n    foreach (var book in MockDatabase.Books)\r\n    {\r\n        AnsiConsole.MarkupLine($\"- [cyan]{book.Name}[/] - [yellow]{book.Pages} pages[/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}" },
                                   new Paragraph { Body = "Modify Add book so that we ask for the pages input and add an instance of Book to the list:" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "internal void AddBook()\r\n{\r\n    var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n    var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n    if (MockDatabase.Books.Exists(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n    {\r\n        AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n    }\r\n    else\r\n    {\r\n        var newBook = new Book(title, pages);\r\n        MockDatabase.Books.Add(newBook);\r\n        AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n    }\r\n\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}" },
                                    new Paragraph { Body = "Finally modify the bookToDelete variable in DeleteBook():" },
                                   new Paragraph {
                                       IsCode = true,
                                        Body = "var bookToDelete = AnsiConsole.Prompt(\r\n    new SelectionPrompt&lt;Book&gt;()\r\n        .Title(\"Select a [red]book[/] to delete:\")\r\n        .UseConverter(b => $\"{b.Name}\")\r\n        .AddChoices(MockDatabase.Books));" },
                                    new Paragraph { Body = "Run the app and try to add a new book!" },
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class BooksController\r\n{\r\n    internal void ViewBooks()\r\n    {\r\n        AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n        foreach (var book in MockDatabase.Books)\r\n        {\r\n            AnsiConsole.MarkupLine($\"- [cyan]{book.Name}[/] - [yellow]{book.Pages} pages[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.Books.Exists(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(title, pages);\r\n            MockDatabase.Books.Add(newBook);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void DeleteBook()\r\n    {\r\n        if (MockDatabase.Books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(MockDatabase.Books));\r\n\r\n        if (MockDatabase.Books.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private BooksController booksController = new BooksController();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                    new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    booksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    booksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    booksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;Book&gt; Books = new()\r\n        {\r\n            new Book(\"The Great Gatsby\", 180),\r\n            new Book(\"To Kill a Mockingbird\", 281),\r\n            new Book(\"1984\", 328),\r\n            new Book(\"Pride and Prejudice\", 432),\r\n            new Book(\"The Catcher in the Rye\", 277),\r\n            new Book(\"The Hobbit\", 310),\r\n            new Book(\"Moby-Dick\", 585),\r\n            new Book(\"War and Peace\", 1225),\r\n            new Book(\"The Odyssey\", 400),\r\n            new Book(\"The Lord of the Rings\", 1178),\r\n            new Book(\"Jane Eyre\", 500),\r\n            new Book(\"Animal Farm\", 112),\r\n            new Book(\"Brave New World\", 268),\r\n            new Book(\"The Chronicles of Narnia\", 768),\r\n            new Book(\"The Diary of a Young Girl\", 283),\r\n            new Book(\"The Alchemist\", 208),\r\n            new Book(\"Wuthering Heights\", 400),\r\n            new Book(\"Fahrenheit 451\", 158),\r\n            new Book(\"Catch-22\", 453),\r\n            new Book(\"The Hitchhiker's Guide to the Galaxy\", 224)\r\n        };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Book\r\n{\r\n    public string Name { get; set; } = \"Unknown\";\r\n    public int Pages { get; set; } = 0;\r\n\r\n    public Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n    }\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500017,
                        CourseDisplayId = 18,
                        Title = "Abstract Classes",
                        Slug = "object-oriented-abstract-classes",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In Program.cs, write the following code:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "internal abstract class Animal\r\n    {\r\n        public string Name { get; set; }\r\n        public int Age { get; set; }\r\n\r\n        protected Animal(string name, int age)\r\n        {\r\n            Name = name;\r\n            Age = age;\r\n        }\r\n\r\n        // Abstract method that must be implemented by derived classes\r\n        public abstract void MakeSound();\r\n    }" }
                                }
                            },
                            new Block
                            {
                                Title = "Abstract Classes",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "This class has two things we haven't seen before. The abstract keyword, and a method without a code block." },
                                     new Paragraph {
                                        Body = "The class Animal is declared as abstract, which means it cannot be instantiated directly. Instead, it serves as a blueprint for other classes that will inherit from it." },
                                     new Paragraph {
                                        Body = "An abstract class can contain both abstract methods (without implementation) and concrete methods (with implementation)." }
                                }
                            },
                            new Block
                            {
                                Title = "Inheritance",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Inheritance in object-oriented programming (OOP) allows one class to inherit the properties and methods of another class, facilitating code reusability and establishing a hierarchical relationship. Let's see it in practice. Add this to Program.cs:" },
                                   new Paragraph {
                                       IsCode = true,
                                       Body = "internal class Dog : Animal\r\n    {\r\n        public Dog(string name, int age) \r\n            : base(name, age) \r\n        {\r\n        }\r\n\r\n        public override void MakeSound()\r\n        {\r\n            Console.WriteLine($\"{Name} says: Woof!\");\r\n        }\r\n    }\r\n\r\ninternal class Cat : Animal\r\n    {\r\n        public Cat(string name, int age) \r\n            : base(name, age) // Calling the base class constructor\r\n        {\r\n        }\r\n\r\n        public override void MakeSound()\r\n        {\r\n            Console.WriteLine($\"{Name} says: Meow!\");\r\n        }\r\n    }" },
                                    new Paragraph { Body = "Both the classes inherit from Animal, Implements the MakeSound() method to provide the specific sound the animal makes. The constructor calls the base constructor to initialize Name and Age." },
                                       new Paragraph { Body = "Add this to Program.cs, above the declaration of the classes:" },
                                       new Paragraph {
                                       IsCode = true,
                                        Body = "Animal myDog = new Dog(\"Buddy\", 3);\r\nAnimal myCat = new Cat(\"Whiskers\", 2);\r\n\r\nmyDog.MakeSound(); // Output: Buddy says: Woof!\r\nmyCat.MakeSound(); // Output: Whiskers says: Meow!" }
                                }
                            },
                            new Block
                            {
                                Title = "Polymorphism",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Polymorphism is a fundamental concept in object-oriented programming (OOP) that allows objects of different classes to be treated as objects of a common superclass. The term “polymorphism” literally means “many shapes,” and it refers to the ability of different objects to respond to the same method call in different ways." },
                                    new Paragraph { Body = "In our example, we have different forms of animals, the cat and the dog. They share common characteristics but also contain unique properties. In the next chapter lets's apply this concept to our Library Management System." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500018,
                        CourseDisplayId = 19,
                        Title = "Applying Abstract Classes",
                        Slug = "applying-abstract-classes",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Our library app will need to support not only books but also magazines and newspapers. Since these entities will have common as well as unique characteristics, it's a perfect use case for inheritance. Let's start by creating a folder called Models containing a LibraryItem.cs abstract class:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "namespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal abstract class LibraryItem\r\n{\r\n    public int Id { get; set; }\r\n    public string Name { get; set; }\r\n    public string Location { get; set; }\r\n\r\n    protected LibraryItem(int id, string name, string location)\r\n    {\r\n        Id = id;\r\n        Name = name;\r\n        Location = location;\r\n    }\r\n\r\n    public abstract void DisplayDetails();\r\n}\r\n" },
                                    new Paragraph { Body = "This class will serve as a base for all items in our library. It makes sense to think that all items will have an id, a name and a location in the library, regardless of its type. We should also be able to display details of any item." },
                                }
                            },
                            new Block
                            {
                                Title = "Modifying Book.cs",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now move Book.cs to the Models folder, and modify it so it inherits from LibraryItem:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "internal class Book : LibraryItem\r\n{\r\n    internal string Author { get; set; }\r\n    internal string Category { get; set; }\r\n    internal int Pages { get; set; }\r\n\r\n    internal Book(int id, string name, string author, string category, string location, int pages)\r\n        : base(id, name, location)\r\n    {\r\n        Author = author;\r\n        Category = category;\r\n        Pages = pages;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]\") +\r\n                              $\"\\n[bold]Pages:[/] {Pages}\" +\r\n                              $\"\\n[bold]Category:[/] [green]{Category}[/]\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}" },
                                     new Paragraph {
                                        Body = "Here we have three fields that are unique to Book: Author, Category and Pages. The constructor tells us we need to initiate these three, plus the properties of the base class. This class also implements it own DisplayDetails() using the override keyword." }
                                }
                            },
                            new Block
                            {
                                Title = "Magazine and Newspaper",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In the Models folder, let's create a Magazine.cs and a Newspaper.cs files and repeat the process:" },
                                   new Paragraph {
                                       IsCode = true,
                                       Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Magazine : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n    public int IssueNumber { get; set; }\r\n\r\n    public Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n        IssueNumber = issueNumber;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Issue Number:[/] {IssueNumber}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}" },
                                       new Paragraph {
                                       IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Newspaper : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n\r\n    public Newspaper(int id, string name, string publisher, DateTime publishDate, string location)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Newspaper:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n" },
                                       new Paragraph { Body = "Study the classes carefully. They are very similar to Book, but contain properties specific to them, along with their own implementation of DisplayDetails()." },
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class BooksController\r\n{\r\n    internal void ViewBooks()\r\n    {\r\n        AnsiConsole.MarkupLine(\"[yellow]List of Books:[/]\");\r\n\r\n        foreach (var book in MockDatabase.Books)\r\n        {\r\n            AnsiConsole.MarkupLine($\"- [cyan]{book.Name}[/] - [yellow]{book.Pages} pages[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.Books.Exists(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(title, pages);\r\n            MockDatabase.Books.Add(newBook);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void DeleteBook()\r\n    {\r\n        if (MockDatabase.Books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(MockDatabase.Books));\r\n\r\n        if (MockDatabase.Books.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private BooksController booksController = new BooksController();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                    new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    booksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    booksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    booksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;Book&gt; Books = new()\r\n        {\r\n            new Book(\"The Great Gatsby\", 180),\r\n            new Book(\"To Kill a Mockingbird\", 281),\r\n            new Book(\"1984\", 328),\r\n            new Book(\"Pride and Prejudice\", 432),\r\n            new Book(\"The Catcher in the Rye\", 277),\r\n            new Book(\"The Hobbit\", 310),\r\n            new Book(\"Moby-Dick\", 585),\r\n            new Book(\"War and Peace\", 1225),\r\n            new Book(\"The Odyssey\", 400),\r\n            new Book(\"The Lord of the Rings\", 1178),\r\n            new Book(\"Jane Eyre\", 500),\r\n            new Book(\"Animal Farm\", 112),\r\n            new Book(\"Brave New World\", 268),\r\n            new Book(\"The Chronicles of Narnia\", 768),\r\n            new Book(\"The Diary of a Young Girl\", 283),\r\n            new Book(\"The Alchemist\", 208),\r\n            new Book(\"Wuthering Heights\", 400),\r\n            new Book(\"Fahrenheit 451\", 158),\r\n            new Book(\"Catch-22\", 453),\r\n            new Book(\"The Hitchhiker's Guide to the Galaxy\", 224)\r\n        };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Book\r\n{\r\n    public string Name { get; set; } = \"Unknown\";\r\n    public int Pages { get; set; } = 0;\r\n\r\n    public Book(string name, int pages)\r\n    {\r\n        Name = name;\r\n        Pages = pages;\r\n    }\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500019,
                        CourseDisplayId = 20,
                        Title = "Refactoring",
                        Slug = "oop-refactoring",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "At the moment our app doesn't compile since we've changed the namespace and the implementation of the Book class. Let's fix it. Start by updating the Mockdatabase so it now starts with 5 objects of each of the LibraryItem types:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "internal static class MockDatabase\r\n{\r\n    internal static List&lt;LibraryItem&gt; LibraryItems = new()\r\n    {\r\n        new Book(1, \"The Great Gatsby\", \"F. Scott Fitzgerald\", \"Fiction\", \"A1\", 218),\r\n        new Book(2, \"To Kill a Mockingbird\", \"Harper Lee\", \"Fiction\", \"A2\", 324),\r\n        new Book(3, \"1984\", \"George Orwell\", \"Dystopian\", \"A3\", 328),\r\n        new Book(4, \"Pride and Prejudice\", \"Jane Austen\", \"Romance\", \"A4\", 279),\r\n        new Book(5, \"The Catcher in the Rye\", \"J.D. Salinger\", \"Fiction\", \"A5\", 214),\r\n\r\n        new Magazine(1, \"National Geographic\", \"National Geographic Partners\", new DateTime(2024, 8, 1), \"B1\", 12),\r\n        new Magazine(2, \"Time\", \"Time USA, LLC\", new DateTime(2024, 7, 15), \"B2\", 8),\r\n        new Magazine(3, \"The Economist\", \"The Economist Group\", new DateTime(2024, 6, 10), \"B3\", 16),\r\n        new Magazine(4, \"Forbes\", \"Forbes Media\", new DateTime(2024, 5, 20), \"B4\", 10),\r\n        new Magazine(5, \"Wired\", \"Condé Nast\", new DateTime(2024, 4, 5), \"B5\", 15),\r\n\r\n        new Newspaper(1, \"The New York Times\", \"The New York Times Company\", new DateTime(2024, 8, 18), \"C1\"),\r\n        new Newspaper(2, \"The Guardian\", \"Guardian Media Group\", new DateTime(2024, 8, 17), \"C2\"),\r\n        new Newspaper(3, \"The Washington Post\", \"Nash Holdings\", new DateTime(2024, 8, 16), \"C3\"),\r\n        new Newspaper(4, \"The Wall Street Journal\", \"Dow Jones & Company\", new DateTime(2024, 8, 15), \"C4\"),\r\n        new Newspaper(5, \"USA Today\", \"Gannett\", new DateTime(2024, 8, 14), \"C5\")\r\n    };\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "Modifying BooksController",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Next we need to modify BooksController. Let's start with the ViewBooks methods, where we will display a table with the information about books:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "internal void ViewBooks()\r\n{\r\n    var table = new Table();\r\n    table.Border(TableBorder.Rounded);\r\n\r\n    table.AddColumn(\"[yellow]ID[/]\");\r\n    table.AddColumn(\"[yellow]Title[/]\");\r\n    table.AddColumn(\"[yellow]Author[/]\");\r\n    table.AddColumn(\"[yellow]Category[/]\");\r\n    table.AddColumn(\"[yellow]Location[/]\");\r\n    table.AddColumn(\"[yellow]Pages[/]\");\r\n\r\n    // Filtering only items of the book type\r\n    var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;();\r\n\r\n    foreach (var book in books)\r\n    {\r\n        table.AddRow(\r\n            book.Id.ToString(),\r\n            $\"[cyan]{book.Name}[/]\",\r\n            $\"[cyan]{book.Author}[/]\",\r\n            $\"[green]{book.Category}[/]\",\r\n            $\"[blue]{book.Location}[/]\",\r\n            book.Pages.ToString()\r\n            );\r\n    }\r\n\r\n    AnsiConsole.Write(table);\r\n    AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n    Console.ReadKey();\r\n}" },
                                     new Paragraph {
                                        Body = "Notice we have a books variable that contains items of the LibraryItems list, as long as they are of the Book type. That is done with the help of the OfType<> extension method." },
                                     new Paragraph { Body = "In the AddBook method we need to get the user input for the missing properties:" },
                                    new Paragraph {
                                       IsCode = true,
                                       Body = " public void AddBook()\r\n {\r\n     var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n     var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n     var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n     var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n     var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n     if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n     {\r\n         AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n     }\r\n     else\r\n     {\r\n         var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n         MockDatabase.LibraryItems.Add(newBook);\r\n         AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n     }\r\n\r\n     AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n     Console.ReadKey();\r\n }\r\n" },
                                }
                            },
                            new Block
                            {
                                Title = "Delete Method",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Try fixing the DeleteBook method using what you've learned in the code above. You can find the code in the link at the end of the page. " },
                                    new Paragraph { Body = "With that step, our app is no longer broken! Run it and you'll be able to add a book with all of it's properties." }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class BooksController\r\n{\r\n    internal void ViewBooks()\r\n    {\r\n        var table = new Table();\r\n        table.Border(TableBorder.Rounded);\r\n\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Author[/]\");\r\n        table.AddColumn(\"[yellow]Category[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n        table.AddColumn(\"[yellow]Pages[/]\");\r\n\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;();\r\n\r\n        foreach (var book in books)\r\n        {\r\n            table.AddRow(\r\n                book.Id.ToString(),\r\n                $\"[cyan]{book.Name}[/]\",\r\n                $\"[cyan]{book.Author}[/]\",\r\n                $\"[green]{book.Category}[/]\",\r\n                $\"[blue]{book.Location}[/]\",\r\n                book.Pages.ToString()\r\n                );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddBook()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n        var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n            MockDatabase.LibraryItems.Add(newBook);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    internal void DeleteBook()\r\n    {\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;().ToList();\r\n\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(books));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuOption\r\n    {\r\n        Viewbooks,\r\n        AddBook,\r\n        DeleteBook\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private BooksController booksController = new BooksController();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            var choice = AnsiConsole.Prompt(\r\n                    new SelectionPrompt&lt;MenuOption&gt;()\r\n                    .Title(\"What do you want to do next?\")\r\n                    .AddChoices(Enum.GetValues&lt;MenuOption&gt;()));\r\n\r\n            switch (choice)\r\n            {\r\n                case MenuOption.Viewbooks:\r\n                    booksController.ViewBooks();\r\n                    break;\r\n                case MenuOption.AddBook:\r\n                    booksController.AddBook();\r\n                    break;\r\n                case MenuOption.DeleteBook:\r\n                    booksController.DeleteBook();\r\n                    break;\r\n            }\r\n        }\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;LibraryItem&gt; LibraryItems = new()\r\n    {\r\n        new Book(1, \"The Great Gatsby\", \"F. Scott Fitzgerald\", \"Fiction\", \"A1\", 218),\r\n        new Book(2, \"To Kill a Mockingbird\", \"Harper Lee\", \"Fiction\", \"A2\", 324),\r\n        new Book(3, \"1984\", \"George Orwell\", \"Dystopian\", \"A3\", 328),\r\n        new Book(4, \"Pride and Prejudice\", \"Jane Austen\", \"Romance\", \"A4\", 279),\r\n        new Book(5, \"The Catcher in the Rye\", \"J.D. Salinger\", \"Fiction\", \"A5\", 214),\r\n\r\n        new Magazine(1, \"National Geographic\", \"National Geographic Partners\", new DateTime(2024, 8, 1), \"B1\", 12),\r\n        new Magazine(2, \"Time\", \"Time USA, LLC\", new DateTime(2024, 7, 15), \"B2\", 8),\r\n        new Magazine(3, \"The Economist\", \"The Economist Group\", new DateTime(2024, 6, 10), \"B3\", 16),\r\n        new Magazine(4, \"Forbes\", \"Forbes Media\", new DateTime(2024, 5, 20), \"B4\", 10),\r\n        new Magazine(5, \"Wired\", \"Condé Nast\", new DateTime(2024, 4, 5), \"B5\", 15),\r\n\r\n        new Newspaper(1, \"The New York Times\", \"The New York Times Company\", new DateTime(2024, 8, 18), \"C1\"),\r\n        new Newspaper(2, \"The Guardian\", \"Guardian Media Group\", new DateTime(2024, 8, 17), \"C2\"),\r\n        new Newspaper(3, \"The Washington Post\", \"Nash Holdings\", new DateTime(2024, 8, 16), \"C3\"),\r\n        new Newspaper(4, \"The Wall Street Journal\", \"Dow Jones & Company\", new DateTime(2024, 8, 15), \"C4\"),\r\n        new Newspaper(5, \"USA Today\", \"Gannett\", new DateTime(2024, 8, 14), \"C5\")\r\n    };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Book : LibraryItem\r\n{\r\n    public string Author { get; set; }\r\n    public string Category { get; set; }\r\n    public int Pages { get; set; }\r\n\r\n    public Book(int id, string name, string author, string category, string location, int pages)\r\n        : base(id, name, location)\r\n    {\r\n        Author = author;\r\n        Category = category;\r\n        Pages = pages;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]\") +\r\n                              $\"\\n[bold]Pages:[/] {Pages}\" +\r\n                              $\"\\n[bold]Category:[/] [green]{Category}[/]\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Magazine.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Magazine : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n    public int IssueNumber { get; set; }\r\n\r\n    public Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n        IssueNumber = issueNumber;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Issue Number:[/] {IssueNumber}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Newspaper.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Newspaper : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n\r\n    public Newspaper(int id, string name, string publisher, DateTime publishDate, string location)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Newspaper:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/LibraryItem.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal abstract class LibraryItem\r\n{\r\n    public int Id { get; set; }\r\n    public string Name { get; set; }\r\n    public string Location { get; set; }\r\n\r\n    protected LibraryItem(int id, string name, string location)\r\n    {\r\n        Id = id;\r\n        Name = name;\r\n        Location = location;\r\n    }\r\n\r\n    public abstract void DisplayDetails();\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500020,
                        CourseDisplayId = 21,
                        Title = "Interfaces",
                        Slug = "interfaces",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "An interface defines a contract that classes can implement. It specifies what a class must do, but not how it does it. Unlike abstract classes, interfaces cannot contain implementation details (prior to C# 8.0; newer versions allow default implementations, but we'll focus on the traditional usage for clarity)." },
                                    new Paragraph {
                                       Body = "Interfaces and Abstract Classes are very similar, particularly after interfaces started allowing default implementations. The most important difference is that a class can implement from multiple interfaces and that's not the case with Abstract classes. Let's see an example. " },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "   public interface IAnimal\r\n    {\r\n        string Name { get; set; }\r\n        int Age { get; set; }\r\n\r\n        void MakeSound();\r\n    }\r\n\r\n public interface IMammal\r\n    {\r\n        bool HasFur { get; set; }\r\n\r\n        void NurseYoung();\r\n    }\r\n\r\npublic interface IPet\r\n    {\r\n        void Play();\r\n    }\r\n\r\npublic class Dog : IAnimal, IMammal, IPet\r\n    {\r\n        public string Name { get; set; }\r\n        public int Age { get; set; }\r\n        public bool HasFur { get; set; }\r\n      \r\n        public Dog(string name, int age, bool hasFur)\r\n        {\r\n            Name = name;\r\n            Age = age;\r\n            HasFur = hasFur;\r\n        }\r\n\r\n        public void MakeSound()\r\n        {\r\n            Console.WriteLine($\"{Name} says: Woof!\");\r\n        }\r\n\r\n        public void NurseYoung()\r\n        {\r\n            Console.WriteLine($\"{Name} is nursing its puppies.\");\r\n        }\r\n\r\n        public void Play()\r\n        {\r\n            Console.WriteLine($\"{Name} is playing fetch.\");\r\n        }\r\n    }" },
                                     new Paragraph {
                                       Body = "Here our dog inherits from multiple interfaces. That's a very common scenario in real applications, since each interface encapsulates a set of related properties and methods. Classes might inherit from difference interfaces as they need those set of members. A good way to think about it is that we should create interfaces so that they're used in a \"per need\" basis." },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500021,
                        CourseDisplayId = 22,
                        Title = "Applying Interfaces",
                        Slug = "applying-interfaces",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "You probably realized we don't have a controller for Magazines and Newspapers. That means we can't do anything with those entities. Let's fix that by creating a controller for each. Since many of the methods will be similar amongst controller, we can use Inheritance." }
                                }
                            },
                            new Block
                            {
                                Title = "Base Controller",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Create a folder called Controllers containing an interface with the following code:" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "internal interface IBaseController\r\n{\r\n    void ViewItems();\r\n    void AddItem();\r\n    void DeleteItem();\r\n}" },
                                     new Paragraph {
                                       Body = "Next modify the BooksController so it inherits from IBaseController. You'll need to modify the names of the methods:" },
                                      new Paragraph {
                                        IsCode = true,
                                       Body = "﻿using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagement.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagement.Controllers;\r\n\r\ninternal class BookController : IBaseController\r\n{\r\n    public void AddItem()\r\n    {\r\n        // Implementation\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n       // Implementation\r\n    }\r\n\r\n    public void ViewItems()\r\n    {\r\n        // Implementation\r\n    }\r\n}" },
                                }
                            },
                            new Block
                            {
                                Title = "More Controllers",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In the same folder create a MagazineController class:" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "internal class MagazineController: IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Issue Number[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var magazines = MockDatabase.LibraryItems.OfType&lt;Magazine&gt;();\r\n\r\n        foreach (var magazine in magazines)\r\n        {\r\n            table.AddRow(\r\n                magazine.Id.ToString(),\r\n                $\"[cyan]{magazine.Name}[/]\",\r\n                $\"[cyan]{magazine.Publisher}[/]\",\r\n                $\"[cyan]{magazine.PublishDate:MMMM dd, yyyy}[/]\",\r\n                magazine.IssueNumber.ToString(),\r\n                $\"[blue]{magazine.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the magazine to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the magazine:\");\r\n        var publishDate = AnsiConsole.Ask&lt;DateTime&gt;(\"Enter the [green]publish date[/] of the magazine (yyyy-mm-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the magazine:\");\r\n        var issueNumber = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]issue number[/] of the magazine:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Any(m => m.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This magazine already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newMagazine = new Magazine(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location, issueNumber);\r\n            MockDatabase.LibraryItems.Add(newMagazine);\r\n            AnsiConsole.MarkupLine(\"[green]Magazine added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No magazines available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var magazineToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Magazine&gt;()\r\n                .Title(\"Select a [red]magazine[/] to delete:\")\r\n                .UseConverter(m => $\"{m.Name} (Issue {m.IssueNumber})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Magazine&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(magazineToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}" },
                                     new Paragraph {
                                       Body = "Finally Create a NewspaperController class:" },
                                      new Paragraph {
                                        IsCode = true,
                                       Body = "﻿using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagement.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagement.Controllers;\r\n\r\ninternal class NewspaperController: IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var newspapers = MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;();\r\n\r\n        foreach (var newspaper in newspapers)\r\n        {\r\n            table.AddRow(\r\n                newspaper.Id.ToString(),\r\n                $\"[cyan]{newspaper.Name}[/]\",\r\n                $\"[cyan]{newspaper.Publisher}[/]\",\r\n                $\"[cyan]{newspaper.PublishDate:yyyy-MM-dd}[/]\",\r\n                $\"[blue]{newspaper.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the newspaper to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the newspaper:\");\r\n        var publishDate = AnsiConsole.Ask&lt;DateTime&gt;(\"Enter the [green]publish date[/] of the newspaper (yyyy-MM-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the newspaper:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Any(n => n.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This newspaper already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newNewspaper = new Newspaper(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location);\r\n            MockDatabase.LibraryItems.Add(newNewspaper);\r\n            AnsiConsole.MarkupLine(\"[green]Newspaper added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No newspapers available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var newspaperToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Newspaper&gt;()\r\n                .Title(\"Select a [red]newspaper[/] to delete:\")\r\n                .UseConverter(n => $\"{n.Name} (Published on {n.PublishDate:yyyy-MM-dd})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(newspaperToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}" },
                                       new Paragraph {
                                       Body = "Study the code closely. Although it's a lot of new code, there aren't new concepts in these methods. These are similar to the implementation of the Books Controller, but with details specific to Magazines and Newspapers." },
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\npublic class BooksController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n        table.Border(TableBorder.Rounded);\r\n\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Author[/]\");\r\n        table.AddColumn(\"[yellow]Category[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n        table.AddColumn(\"[yellow]Pages[/]\");\r\n\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;();\r\n\r\n        foreach (var book in books)\r\n        {\r\n            table.AddRow(\r\n                book.Id.ToString(),\r\n                $\"[cyan]{book.Name}[/]\",\r\n                $\"[cyan]{book.Author}[/]\",\r\n                $\"[green]{book.Category}[/]\",\r\n                $\"[blue]{book.Location}[/]\",\r\n                book.Pages.ToString()\r\n                );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n        var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n            MockDatabase.LibraryItems.Add(newBook);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;().ToList();\r\n\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(books));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/MagazineController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class MagazineController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Issue Number[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var magazines = MockDatabase.LibraryItems.OfType&lt;Magazine&gt;();\r\n\r\n        foreach (var magazine in magazines)\r\n        {\r\n            table.AddRow(\r\n                magazine.Id.ToString(),\r\n                $\"[cyan]{magazine.Name}[/]\",\r\n                $\"[cyan]{magazine.Publisher}[/]\",\r\n                $\"[cyan]{magazine.PublishDate:MMMM dd, yyyy}[/]\",\r\n                magazine.IssueNumber.ToString(),\r\n                $\"[blue]{magazine.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the magazine to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the magazine:\");\r\n        var publishDate = AnsiConsole.Ask&lt;DateTime&gt;(\"Enter the [green]publish date[/] of the magazine (yyyy-mm-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the magazine:\");\r\n        var issueNumber = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]issue number[/] of the magazine:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Any(m => m.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This magazine already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newMagazine = new Magazine(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location, issueNumber);\r\n            MockDatabase.LibraryItems.Add(newMagazine);\r\n            AnsiConsole.MarkupLine(\"[green]Magazine added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No magazines available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var magazineToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Magazine&gt;()\r\n                .Title(\"Select a [red]magazine[/] to delete:\")\r\n                .UseConverter(m => $\"{m.Name} (Issue {m.IssueNumber})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Magazine&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(magazineToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/NewspaperController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class NewspaperController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var newspapers = MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;();\r\n\r\n        foreach (var newspaper in newspapers)\r\n        {\r\n            table.AddRow(\r\n                newspaper.Id.ToString(),\r\n                $\"[cyan]{newspaper.Name}[/]\",\r\n                $\"[cyan]{newspaper.Publisher}[/]\",\r\n                $\"[cyan]{newspaper.PublishDate:yyyy-MM-dd}[/]\",\r\n                $\"[blue]{newspaper.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the newspaper to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the newspaper:\");\r\n        var publishDate = AnsiConsole.Ask&lt;DateTime&gt;(\"Enter the [green]publish date[/] of the newspaper (yyyy-MM-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the newspaper:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Any(n => n.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This newspaper already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newNewspaper = new Newspaper(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location);\r\n            MockDatabase.LibraryItems.Add(newNewspaper);\r\n            AnsiConsole.MarkupLine(\"[green]Newspaper added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No newspapers available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var newspaperToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Newspaper&gt;()\r\n                .Title(\"Select a [red]newspaper[/] to delete:\")\r\n                .UseConverter(n => $\"{n.Name} (Published on {n.PublishDate:yyyy-MM-dd})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(newspaperToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/IBaseController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal interface IBaseController\r\n{\r\n    void ViewItems();\r\n    void AddItem();\r\n    void DeleteItem();\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuAction\r\n    {\r\n        ViewItem,\r\n        AddItem,\r\n        DeleteItem\r\n    }\r\n\r\n    internal enum ItemType\r\n    {\r\n        Book,\r\n        Magazine,\r\n        Newspaper\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Controllers;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private readonly BooksController _booksController = new();\r\n    private readonly MagazineController _magazinesController = new();\r\n    private readonly NewspaperController _newspapersController = new();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            Console.Clear();\r\n\r\n            var actionChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;MenuAction&gt;()\r\n                .Title(\"What do you want to do next?\")\r\n                .AddChoices(Enum.GetValues&lt;MenuAction&gt;()));\r\n\r\n            var itemTypeChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;ItemType&gt;()\r\n                .Title(\"Select the type of item:\")\r\n                .AddChoices(Enum.GetValues&lt;ItemType&gt;()));\r\n\r\n            switch (actionChoice)\r\n            {\r\n                case MenuAction.ViewItem:\r\n                    ViewItems(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.AddItem:\r\n                    AddItem(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.DeleteItem:\r\n                    DeleteItem(itemTypeChoice);\r\n                    break;\r\n            }\r\n\r\n\r\n        }\r\n    }\r\n\r\n    private void ViewItems(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.ViewItems();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.ViewItems();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.ViewItems();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void AddItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.AddItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.AddItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.AddItem();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void DeleteItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.DeleteItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.DeleteItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.DeleteItem();\r\n                break;\r\n        }\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;LibraryItem&gt; LibraryItems = new()\r\n    {\r\n        new Book(1, \"The Great Gatsby\", \"F. Scott Fitzgerald\", \"Fiction\", \"A1\", 218),\r\n        new Book(2, \"To Kill a Mockingbird\", \"Harper Lee\", \"Fiction\", \"A2\", 324),\r\n        new Book(3, \"1984\", \"George Orwell\", \"Dystopian\", \"A3\", 328),\r\n        new Book(4, \"Pride and Prejudice\", \"Jane Austen\", \"Romance\", \"A4\", 279),\r\n        new Book(5, \"The Catcher in the Rye\", \"J.D. Salinger\", \"Fiction\", \"A5\", 214),\r\n\r\n        new Magazine(1, \"National Geographic\", \"National Geographic Partners\", new DateTime(2024, 8, 1), \"B1\", 12),\r\n        new Magazine(2, \"Time\", \"Time USA, LLC\", new DateTime(2024, 7, 15), \"B2\", 8),\r\n        new Magazine(3, \"The Economist\", \"The Economist Group\", new DateTime(2024, 6, 10), \"B3\", 16),\r\n        new Magazine(4, \"Forbes\", \"Forbes Media\", new DateTime(2024, 5, 20), \"B4\", 10),\r\n        new Magazine(5, \"Wired\", \"Condé Nast\", new DateTime(2024, 4, 5), \"B5\", 15),\r\n\r\n        new Newspaper(1, \"The New York Times\", \"The New York Times Company\", new DateTime(2024, 8, 18), \"C1\"),\r\n        new Newspaper(2, \"The Guardian\", \"Guardian Media Group\", new DateTime(2024, 8, 17), \"C2\"),\r\n        new Newspaper(3, \"The Washington Post\", \"Nash Holdings\", new DateTime(2024, 8, 16), \"C3\"),\r\n        new Newspaper(4, \"The Wall Street Journal\", \"Dow Jones & Company\", new DateTime(2024, 8, 15), \"C4\"),\r\n        new Newspaper(5, \"USA Today\", \"Gannett\", new DateTime(2024, 8, 14), \"C5\")\r\n    };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Book : LibraryItem\r\n{\r\n    public string Author { get; set; }\r\n    public string Category { get; set; }\r\n    public int Pages { get; set; }\r\n\r\n    public Book(int id, string name, string author, string category, string location, int pages)\r\n        : base(id, name, location)\r\n    {\r\n        Author = author;\r\n        Category = category;\r\n        Pages = pages;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]\") +\r\n                              $\"\\n[bold]Pages:[/] {Pages}\" +\r\n                              $\"\\n[bold]Category:[/] [green]{Category}[/]\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Magazine.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Magazine : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n    public int IssueNumber { get; set; }\r\n\r\n    public Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n        IssueNumber = issueNumber;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Issue Number:[/] {IssueNumber}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Newspaper.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Newspaper : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n\r\n    public Newspaper(int id, string name, string publisher, DateTime publishDate, string location)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Newspaper:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/LibraryItem.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal abstract class LibraryItem\r\n{\r\n    public int Id { get; set; }\r\n    public string Name { get; set; }\r\n    public string Location { get; set; }\r\n\r\n    protected LibraryItem(int id, string name, string location)\r\n    {\r\n        Id = id;\r\n        Name = name;\r\n        Location = location;\r\n    }\r\n\r\n    public abstract void DisplayDetails();\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500022,
                        CourseDisplayId = 23,
                        Title = "Modifying The Menu",
                        Slug = "oop-modifying-menu",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "If you tried to run the app after the last chapter you probably realized we still can't do anything with Magazines and Newspapers! The final step to make that happens is to modify the Menus in the UserInterface class." }
                                }
                            },
                            new Block
                            {
                                Title = "One More Enum",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "First modify Enums.cs according to this code:" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "internal class Enums\r\n{\r\n    internal enum MenuAction\r\n    {\r\n        ViewItem,\r\n        AddItem,\r\n        DeleteItem\r\n    }\r\n\r\n    internal enum ItemType\r\n    {\r\n        Book,\r\n        Magazine,\r\n        Newspaper\r\n    }\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "Two Choices",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Proceed to modify UserInterface.cs:" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "namespace TCSA.OOP.LibraryManagement;\r\n\r\ninternal class UserInterface\r\n{\r\n    private readonly BookController _booksController = new();\r\n    private readonly MagazineController _magazinesController = new();\r\n    private readonly NewspaperController _newspapersController = new();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            Console.Clear();\r\n\r\n            var actionChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;MenuAction&gt;()\r\n                .Title(\"What do you want to do next?\")\r\n                .AddChoices(Enum.GetValues&lt;MenuAction&gt;()));\r\n\r\n            var itemTypeChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;ItemType&gt;()\r\n                .Title(\"Select the type of item:\")\r\n                .AddChoices(Enum.GetValues&lt;ItemType&gt;()));\r\n\r\n            switch (actionChoice)\r\n            {\r\n                case MenuAction.ViewItem:\r\n                    ViewItems(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.AddItem:\r\n                    AddItem(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.DeleteItem:\r\n                    DeleteItem(itemTypeChoice);\r\n                    break;\r\n            }\r\n\r\n\r\n        }\r\n    }\r\n\r\n    private void ViewItems(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.ViewItems();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.ViewItems();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.ViewItems();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void AddItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.AddItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.AddItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.AddItem();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void DeleteItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.DeleteItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.DeleteItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.DeleteItem();\r\n                break;\r\n        }\r\n    }\r\n}" },
                                     new Paragraph {
                                       Body = "Notice that this class declares all controllers as fields on top of the file. These are marked as readonly." }
                                }
                            },
                             new Block
                            {
                                Title = "Readonly",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In C#, the readonly keyword is used to specify that a field can only be assigned once, either when it's declared or in the constructor of the class. Once assigned, the value of a readonly field cannot be modified. It ensures that the field's value remains constant after its initial assignment, providing a safeguard for certain variables to avoid accidental modification later in the code." },
                                     new Paragraph {
                                       Body = "With this code the users now make two choices. The action and the item type. The methods for each action have ItemType as a parameter and each type branches execution to the corresponding controller." }
                                }
                            },
                              new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\npublic class BooksController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n        table.Border(TableBorder.Rounded);\r\n\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Author[/]\");\r\n        table.AddColumn(\"[yellow]Category[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n        table.AddColumn(\"[yellow]Pages[/]\");\r\n\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;();\r\n\r\n        foreach (var book in books)\r\n        {\r\n            table.AddRow(\r\n                book.Id.ToString(),\r\n                $\"[cyan]{book.Name}[/]\",\r\n                $\"[cyan]{book.Author}[/]\",\r\n                $\"[green]{book.Category}[/]\",\r\n                $\"[blue]{book.Location}[/]\",\r\n                book.Pages.ToString()\r\n                );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n        var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This book already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n            MockDatabase.LibraryItems.Add(newBook);\r\n            AnsiConsole.MarkupLine(\"[green]Book added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;().ToList();\r\n\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .AddChoices(books));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(bookToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Book not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/MagazineController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class MagazineController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Issue Number[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var magazines = MockDatabase.LibraryItems.OfType&lt;Magazine&gt;();\r\n\r\n        foreach (var magazine in magazines)\r\n        {\r\n            table.AddRow(\r\n                magazine.Id.ToString(),\r\n                $\"[cyan]{magazine.Name}[/]\",\r\n                $\"[cyan]{magazine.Publisher}[/]\",\r\n                $\"[cyan]{magazine.PublishDate:MMMM dd, yyyy}[/]\",\r\n                magazine.IssueNumber.ToString(),\r\n                $\"[blue]{magazine.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the magazine to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the magazine:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the magazine (yyyy-mm-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the magazine:\");\r\n        var issueNumber = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]issue number[/] of the magazine:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Any(m => m.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This magazine already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newMagazine = new Magazine(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location, issueNumber);\r\n            MockDatabase.LibraryItems.Add(newMagazine);\r\n            AnsiConsole.MarkupLine(\"[green]Magazine added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No magazines available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var magazineToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Magazine&gt;()\r\n                .Title(\"Select a [red]magazine[/] to delete:\")\r\n                .UseConverter(m => $\"{m.Name} (Issue {m.IssueNumber})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Magazine&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(magazineToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/NewspaperController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class NewspaperController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var newspapers = MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;();\r\n\r\n        foreach (var newspaper in newspapers)\r\n        {\r\n            table.AddRow(\r\n                newspaper.Id.ToString(),\r\n                $\"[cyan]{newspaper.Name}[/]\",\r\n                $\"[cyan]{newspaper.Publisher}[/]\",\r\n                $\"[cyan]{newspaper.PublishDate:yyyy-MM-dd}[/]\",\r\n                $\"[blue]{newspaper.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the newspaper to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the newspaper:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the newspaper (yyyy-MM-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the newspaper:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Any(n => n.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This newspaper already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newNewspaper = new Newspaper(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location);\r\n            MockDatabase.LibraryItems.Add(newNewspaper);\r\n            AnsiConsole.MarkupLine(\"[green]Newspaper added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No newspapers available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var newspaperToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Newspaper&gt;()\r\n                .Title(\"Select a [red]newspaper[/] to delete:\")\r\n                .UseConverter(n => $\"{n.Name} (Published on {n.PublishDate:yyyy-MM-dd})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(newspaperToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/IBaseController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal interface IBaseController\r\n{\r\n    void ViewItems();\r\n    void AddItem();\r\n    void DeleteItem();\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuAction\r\n    {\r\n        ViewItem,\r\n        AddItem,\r\n        DeleteItem\r\n    }\r\n\r\n    internal enum ItemType\r\n    {\r\n        Book,\r\n        Magazine,\r\n        Newspaper\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Controllers;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private readonly BooksController _booksController = new();\r\n    private readonly MagazineController _magazinesController = new();\r\n    private readonly NewspaperController _newspapersController = new();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            Console.Clear();\r\n\r\n            var actionChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;MenuAction&gt;()\r\n                .Title(\"What do you want to do next?\")\r\n                .AddChoices(Enum.GetValues&lt;MenuAction&gt;()));\r\n\r\n            var itemTypeChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;ItemType&gt;()\r\n                .Title(\"Select the type of item:\")\r\n                .AddChoices(Enum.GetValues&lt;ItemType&gt;()));\r\n\r\n            switch (actionChoice)\r\n            {\r\n                case MenuAction.ViewItem:\r\n                    ViewItems(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.AddItem:\r\n                    AddItem(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.DeleteItem:\r\n                    DeleteItem(itemTypeChoice);\r\n                    break;\r\n            }\r\n\r\n\r\n        }\r\n    }\r\n\r\n    private void ViewItems(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.ViewItems();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.ViewItems();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.ViewItems();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void AddItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.AddItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.AddItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.AddItem();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void DeleteItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.DeleteItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.DeleteItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.DeleteItem();\r\n                break;\r\n        }\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;LibraryItem&gt; LibraryItems = new()\r\n    {\r\n        new Book(1, \"The Great Gatsby\", \"F. Scott Fitzgerald\", \"Fiction\", \"A1\", 218),\r\n        new Book(2, \"To Kill a Mockingbird\", \"Harper Lee\", \"Fiction\", \"A2\", 324),\r\n        new Book(3, \"1984\", \"George Orwell\", \"Dystopian\", \"A3\", 328),\r\n        new Book(4, \"Pride and Prejudice\", \"Jane Austen\", \"Romance\", \"A4\", 279),\r\n        new Book(5, \"The Catcher in the Rye\", \"J.D. Salinger\", \"Fiction\", \"A5\", 214),\r\n\r\n        new Magazine(1, \"National Geographic\", \"National Geographic Partners\", new DateTime(2024, 8, 1), \"B1\", 12),\r\n        new Magazine(2, \"Time\", \"Time USA, LLC\", new DateTime(2024, 7, 15), \"B2\", 8),\r\n        new Magazine(3, \"The Economist\", \"The Economist Group\", new DateTime(2024, 6, 10), \"B3\", 16),\r\n        new Magazine(4, \"Forbes\", \"Forbes Media\", new DateTime(2024, 5, 20), \"B4\", 10),\r\n        new Magazine(5, \"Wired\", \"Condé Nast\", new DateTime(2024, 4, 5), \"B5\", 15),\r\n\r\n        new Newspaper(1, \"The New York Times\", \"The New York Times Company\", new DateTime(2024, 8, 18), \"C1\"),\r\n        new Newspaper(2, \"The Guardian\", \"Guardian Media Group\", new DateTime(2024, 8, 17), \"C2\"),\r\n        new Newspaper(3, \"The Washington Post\", \"Nash Holdings\", new DateTime(2024, 8, 16), \"C3\"),\r\n        new Newspaper(4, \"The Wall Street Journal\", \"Dow Jones & Company\", new DateTime(2024, 8, 15), \"C4\"),\r\n        new Newspaper(5, \"USA Today\", \"Gannett\", new DateTime(2024, 8, 14), \"C5\")\r\n    };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Book : LibraryItem\r\n{\r\n    public string Author { get; set; }\r\n    public string Category { get; set; }\r\n    public int Pages { get; set; }\r\n\r\n    public Book(int id, string name, string author, string category, string location, int pages)\r\n        : base(id, name, location)\r\n    {\r\n        Author = author;\r\n        Category = category;\r\n        Pages = pages;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]\") +\r\n                              $\"\\n[bold]Pages:[/] {Pages}\" +\r\n                              $\"\\n[bold]Category:[/] [green]{Category}[/]\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Magazine.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Magazine : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n    public int IssueNumber { get; set; }\r\n\r\n    public Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n        IssueNumber = issueNumber;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Issue Number:[/] {IssueNumber}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Newspaper.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Newspaper : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n\r\n    public Newspaper(int id, string name, string publisher, DateTime publishDate, string location)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Newspaper:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/LibraryItem.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal abstract class LibraryItem\r\n{\r\n    public int Id { get; set; }\r\n    public string Name { get; set; }\r\n    public string Location { get; set; }\r\n\r\n    protected LibraryItem(int id, string name, string location)\r\n    {\r\n        Id = id;\r\n        Name = name;\r\n        Location = location;\r\n    }\r\n\r\n    public abstract void DisplayDetails();\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500023,
                        CourseDisplayId = 24,
                        Title = "Complex Inheritance",
                        Slug = "oop-complex-inheritance",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "C# Also supports inheritance from a base abstract class and interfaces simultaneously.   Let's create another abstract class in the Controllers folder. Notice that this class provides a default implementation of its methods:" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "internal abstract class BaseController\r\n{\r\n    protected void DisplayMessage(string message, string color = \"yellow\")\r\n    {\r\n        AnsiConsole.MarkupLine($\"[{color}]{message}[/]\");\r\n    }\r\n\r\n    protected bool ConfirmDeletion(string itemName)\r\n    {\r\n        var confirm = AnsiConsole.Confirm($\"Are you sure you want to delete [red]{itemName}[/]?\");\r\n\r\n        return confirm;\r\n    }\r\n}" }
                                }
                            },
                            new Block
                            {
                                Title = "Controller",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now modify the Delete and Add methods in BookController.cs" },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "﻿using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagement.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagement.Controllers;\r\n\r\ninternal class BookController : BaseController, IBaseController\r\n{\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n        var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            DisplayMessage(\"Book already exists!\", \"red\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n            MockDatabase.LibraryItems.Add(newBook);\r\n            DisplayMessage(\"Book added successfully!\", \"green\");\r\n        }\r\n\r\n        DisplayMessage(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;().ToList();\r\n\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .UseConverter(b => $\"{b.Name} by {b.Author}\")\r\n                .AddChoices(books));\r\n\r\n        if (ConfirmDeletion(bookToDelete.Name))\r\n        {\r\n            if (MockDatabase.LibraryItems.Remove(bookToDelete))\r\n            {\r\n                DisplayMessage(\"Book deleted successfully!\", \"red\");\r\n            }\r\n            else\r\n            {\r\n                DisplayMessage(\"Book not found.\", \"red\");\r\n            }\r\n        }\r\n        else\r\n        {\r\n            DisplayMessage(\"Deletion canceled.\", \"yellow\");\r\n        }\r\n\r\n        DisplayMessage(\"Press Any Key to Continue.\", \"green\");\r\n        Console.ReadKey();\r\n    }\r\n}" },
                                    new Paragraph { Body = "ViewItems doesn't change, but you can find DisplayMessage used several times to print a message with a specific color. Additionally, in DeleteItem() we're calling ConfirmDeletion() method provided by the base class, asking for a binary selection from the user." },
                                    new Paragraph { Body = "Run the app and you'll be asked for confirmation when trying to delete a record." },
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem;\r\n\r\nUserInterface userInterface = new();\r\nuserInterface.MainMenu();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/BooksController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class BookController : BaseController, IBaseController\r\n{\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the book to add:\");\r\n        var author = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]author[/] of the book:\");\r\n        var category = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]category[/] of the book:\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the book:\");\r\n        var pages = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]number of pages[/] in the book:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Book&gt;().Any(b => b.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            DisplayMessage(\"Book already exists!\", \"red\");\r\n        }\r\n        else\r\n        {\r\n            var newBook = new Book(MockDatabase.LibraryItems.Count + 1, title, author, category, location, pages);\r\n            MockDatabase.LibraryItems.Add(newBook);\r\n            DisplayMessage(\"Book added successfully!\", \"green\");\r\n        }\r\n\r\n        DisplayMessage(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n        table.Border(TableBorder.Rounded);\r\n\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Author[/]\");\r\n        table.AddColumn(\"[yellow]Category[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n        table.AddColumn(\"[yellow]Pages[/]\");\r\n\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;();\r\n\r\n        foreach (var book in books)\r\n        {\r\n            table.AddRow(\r\n                book.Id.ToString(),\r\n                $\"[cyan]{book.Name}[/]\",\r\n                $\"[cyan]{book.Author}[/]\",\r\n                $\"[green]{book.Category}[/]\",\r\n                $\"[blue]{book.Location}[/]\",\r\n                book.Pages.ToString()\r\n                );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        var books = MockDatabase.LibraryItems.OfType&lt;Book&gt;().ToList();\r\n\r\n        if (books.Count == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No books available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var bookToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Book&gt;()\r\n                .Title(\"Select a [red]book[/] to delete:\")\r\n                .UseConverter(b => $\"{b.Name} by {b.Author}\")\r\n                .AddChoices(books));\r\n\r\n        if (ConfirmDeletion(bookToDelete.Name))\r\n        {\r\n            if (MockDatabase.LibraryItems.Remove(bookToDelete))\r\n            {\r\n                DisplayMessage(\"Book deleted successfully!\", \"red\");\r\n            }\r\n            else\r\n            {\r\n                DisplayMessage(\"Book not found.\", \"red\");\r\n            }\r\n        }\r\n        else\r\n        {\r\n            DisplayMessage(\"Deletion canceled.\", \"yellow\");\r\n        }\r\n\r\n        DisplayMessage(\"Press Any Key to Continue.\", \"green\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/MagazineController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class MagazineController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Issue Number[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var magazines = MockDatabase.LibraryItems.OfType&lt;Magazine&gt;();\r\n\r\n        foreach (var magazine in magazines)\r\n        {\r\n            table.AddRow(\r\n                magazine.Id.ToString(),\r\n                $\"[cyan]{magazine.Name}[/]\",\r\n                $\"[cyan]{magazine.Publisher}[/]\",\r\n                $\"[cyan]{magazine.PublishDate:MMMM dd, yyyy}[/]\",\r\n                magazine.IssueNumber.ToString(),\r\n                $\"[blue]{magazine.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the magazine to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the magazine:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the magazine (yyyy-mm-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the magazine:\");\r\n        var issueNumber = AnsiConsole.Ask&lt;int&gt;(\"Enter the [green]issue number[/] of the magazine:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Any(m => m.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This magazine already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newMagazine = new Magazine(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location, issueNumber);\r\n            MockDatabase.LibraryItems.Add(newMagazine);\r\n            AnsiConsole.MarkupLine(\"[green]Magazine added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Magazine&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No magazines available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var magazineToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Magazine&gt;()\r\n                .Title(\"Select a [red]magazine[/] to delete:\")\r\n                .UseConverter(m => $\"{m.Name} (Issue {m.IssueNumber})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Magazine&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(magazineToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Magazine not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/NewspaperController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal class NewspaperController : IBaseController\r\n{\r\n    public void ViewItems()\r\n    {\r\n        var table = new Table();\r\n\r\n        table.Border(TableBorder.Rounded);\r\n        table.AddColumn(\"[yellow]ID[/]\");\r\n        table.AddColumn(\"[yellow]Title[/]\");\r\n        table.AddColumn(\"[yellow]Publisher[/]\");\r\n        table.AddColumn(\"[yellow]Publish Date[/]\");\r\n        table.AddColumn(\"[yellow]Location[/]\");\r\n\r\n        var newspapers = MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;();\r\n\r\n        foreach (var newspaper in newspapers)\r\n        {\r\n            table.AddRow(\r\n                newspaper.Id.ToString(),\r\n                $\"[cyan]{newspaper.Name}[/]\",\r\n                $\"[cyan]{newspaper.Publisher}[/]\",\r\n                $\"[cyan]{newspaper.PublishDate:yyyy-MM-dd}[/]\",\r\n                $\"[blue]{newspaper.Location}[/]\"\r\n            );\r\n        }\r\n\r\n        AnsiConsole.Write(table);\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void AddItem()\r\n    {\r\n        var title = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]title[/] of the newspaper to add:\");\r\n        var publisher = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]publisher[/] of the newspaper:\");\r\n        var publishDate = AnsiConsole.Ask<DateTime>(\"Enter the [green]publish date[/] of the newspaper (yyyy-MM-dd):\");\r\n        var location = AnsiConsole.Ask&lt;string&gt;(\"Enter the [green]location[/] of the newspaper:\");\r\n\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Any(n => n.Name.Equals(title, StringComparison.OrdinalIgnoreCase)))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]This newspaper already exists.[/]\");\r\n        }\r\n        else\r\n        {\r\n            var newNewspaper = new Newspaper(MockDatabase.LibraryItems.Count + 1, title, publisher, publishDate, location);\r\n            MockDatabase.LibraryItems.Add(newNewspaper);\r\n            AnsiConsole.MarkupLine(\"[green]Newspaper added successfully![/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n\r\n    public void DeleteItem()\r\n    {\r\n        if (MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;().Count() == 0)\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]No newspapers available to delete.[/]\");\r\n            Console.ReadKey();\r\n            return;\r\n        }\r\n\r\n        var newspaperToDelete = AnsiConsole.Prompt(\r\n            new SelectionPrompt&lt;Newspaper&gt;()\r\n                .Title(\"Select a [red]newspaper[/] to delete:\")\r\n                .UseConverter(n => $\"{n.Name} (Published on {n.PublishDate:yyyy-MM-dd})\")\r\n                .AddChoices(MockDatabase.LibraryItems.OfType&lt;Newspaper&gt;()));\r\n\r\n        if (MockDatabase.LibraryItems.Remove(newspaperToDelete))\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper deleted successfully![/]\");\r\n        }\r\n        else\r\n        {\r\n            AnsiConsole.MarkupLine(\"[red]Newspaper not found.[/]\");\r\n        }\r\n\r\n        AnsiConsole.MarkupLine(\"Press Any Key to Continue.\");\r\n        Console.ReadKey();\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/BaseController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\ninternal abstract class BaseController\r\n{\r\n    protected void DisplayMessage(string message, string color = \"yellow\")\r\n    {\r\n        AnsiConsole.MarkupLine($\"[{color}]{message}[/]\");\r\n    }\r\n\r\n    protected bool ConfirmDeletion(string itemName)\r\n    {\r\n        var confirm = AnsiConsole.Confirm($\"Are you sure you want to delete [red]{itemName}[/]?\");\r\n\r\n        return confirm;\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Controllers/IBaseController.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Controllers;\r\n\r\ninternal interface IBaseController\r\n{\r\n    void ViewItems();\r\n    void AddItem();\r\n    void DeleteItem();\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Enums.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class Enums\r\n{\r\n    internal enum MenuAction\r\n    {\r\n        ViewItem,\r\n        AddItem,\r\n        DeleteItem\r\n    }\r\n\r\n    internal enum ItemType\r\n    {\r\n        Book,\r\n        Magazine,\r\n        Newspaper\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "UserInterface.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\nusing TCSA.OOP.LibraryManagementSystem.Controllers;\r\nusing static TCSA.OOP.LibraryManagementSystem.Enums;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal class UserInterface\r\n{\r\n    private readonly BooksController _booksController = new();\r\n    private readonly MagazineController _magazinesController = new();\r\n    private readonly NewspaperController _newspapersController = new();\r\n\r\n    internal void MainMenu()\r\n    {\r\n        while (true)\r\n        {\r\n            Console.Clear();\r\n\r\n            var actionChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;MenuAction&gt;()\r\n                .Title(\"What do you want to do next?\")\r\n                .AddChoices(Enum.GetValues&lt;MenuAction&gt;()));\r\n\r\n            var itemTypeChoice = AnsiConsole.Prompt(\r\n                new SelectionPrompt&lt;ItemType&gt;()\r\n                .Title(\"Select the type of item:\")\r\n                .AddChoices(Enum.GetValues&lt;ItemType&gt;()));\r\n\r\n            switch (actionChoice)\r\n            {\r\n                case MenuAction.ViewItem:\r\n                    ViewItems(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.AddItem:\r\n                    AddItem(itemTypeChoice);\r\n                    break;\r\n                case MenuAction.DeleteItem:\r\n                    DeleteItem(itemTypeChoice);\r\n                    break;\r\n            }\r\n\r\n\r\n        }\r\n    }\r\n\r\n    private void ViewItems(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.ViewItems();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.ViewItems();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.ViewItems();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void AddItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.AddItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.AddItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.AddItem();\r\n                break;\r\n        }\r\n    }\r\n\r\n    private void DeleteItem(ItemType itemType)\r\n    {\r\n        switch (itemType)\r\n        {\r\n            case ItemType.Book:\r\n                _booksController.DeleteItem();\r\n                break;\r\n            case ItemType.Magazine:\r\n                _magazinesController.DeleteItem();\r\n                break;\r\n            case ItemType.Newspaper:\r\n                _newspapersController.DeleteItem();\r\n                break;\r\n        }\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "MockDatabase.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem;\r\n\r\ninternal static class MockDatabase\r\n{\r\n    internal static List&lt;LibraryItem&gt; LibraryItems = new()\r\n    {\r\n        new Book(1, \"The Great Gatsby\", \"F. Scott Fitzgerald\", \"Fiction\", \"A1\", 218),\r\n        new Book(2, \"To Kill a Mockingbird\", \"Harper Lee\", \"Fiction\", \"A2\", 324),\r\n        new Book(3, \"1984\", \"George Orwell\", \"Dystopian\", \"A3\", 328),\r\n        new Book(4, \"Pride and Prejudice\", \"Jane Austen\", \"Romance\", \"A4\", 279),\r\n        new Book(5, \"The Catcher in the Rye\", \"J.D. Salinger\", \"Fiction\", \"A5\", 214),\r\n\r\n        new Magazine(1, \"National Geographic\", \"National Geographic Partners\", new DateTime(2024, 8, 1), \"B1\", 12),\r\n        new Magazine(2, \"Time\", \"Time USA, LLC\", new DateTime(2024, 7, 15), \"B2\", 8),\r\n        new Magazine(3, \"The Economist\", \"The Economist Group\", new DateTime(2024, 6, 10), \"B3\", 16),\r\n        new Magazine(4, \"Forbes\", \"Forbes Media\", new DateTime(2024, 5, 20), \"B4\", 10),\r\n        new Magazine(5, \"Wired\", \"Condé Nast\", new DateTime(2024, 4, 5), \"B5\", 15),\r\n\r\n        new Newspaper(1, \"The New York Times\", \"The New York Times Company\", new DateTime(2024, 8, 18), \"C1\"),\r\n        new Newspaper(2, \"The Guardian\", \"Guardian Media Group\", new DateTime(2024, 8, 17), \"C2\"),\r\n        new Newspaper(3, \"The Washington Post\", \"Nash Holdings\", new DateTime(2024, 8, 16), \"C3\"),\r\n        new Newspaper(4, \"The Wall Street Journal\", \"Dow Jones & Company\", new DateTime(2024, 8, 15), \"C4\"),\r\n        new Newspaper(5, \"USA Today\", \"Gannett\", new DateTime(2024, 8, 14), \"C5\")\r\n    };\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Book.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Book : LibraryItem\r\n{\r\n    public string Author { get; set; }\r\n    public string Category { get; set; }\r\n    public int Pages { get; set; }\r\n\r\n    public Book(int id, string name, string author, string category, string location, int pages)\r\n        : base(id, name, location)\r\n    {\r\n        Author = author;\r\n        Category = category;\r\n        Pages = pages;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]\") +\r\n                              $\"\\n[bold]Pages:[/] {Pages}\" +\r\n                              $\"\\n[bold]Category:[/] [green]{Category}[/]\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Magazine.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Magazine : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n    public int IssueNumber { get; set; }\r\n\r\n    public Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n        IssueNumber = issueNumber;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Issue Number:[/] {IssueNumber}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/Newspaper.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "using Spectre.Console;\r\n\r\nnamespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal class Newspaper : LibraryItem\r\n{\r\n    public string Publisher { get; set; }\r\n    public DateTime PublishDate { get; set; }\r\n\r\n    public Newspaper(int id, string name, string publisher, DateTime publishDate, string location)\r\n        : base(id, name, location)\r\n    {\r\n        Publisher = publisher;\r\n        PublishDate = publishDate;\r\n    }\r\n\r\n    public override void DisplayDetails()\r\n    {\r\n        var panel = new Panel(new Markup($\"[bold]Newspaper:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]\") +\r\n                              $\"\\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}\" +\r\n                              $\"\\n[bold]Location:[/] [blue]{Location}[/]\")\r\n        {\r\n            Border = BoxBorder.Rounded\r\n        };\r\n\r\n        AnsiConsole.Write(panel);\r\n    }\r\n}\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Models/LibraryItem.cs",
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                        IsCode = true,
                                        Body = "namespace TCSA.OOP.LibraryManagementSystem.Models;\r\n\r\ninternal abstract class LibraryItem\r\n{\r\n    public int Id { get; set; }\r\n    public string Name { get; set; }\r\n    public string Location { get; set; }\r\n\r\n    protected LibraryItem(int id, string name, string location)\r\n    {\r\n        Id = id;\r\n        Name = name;\r\n        Location = location;\r\n    }\r\n\r\n    public abstract void DisplayDetails();\r\n}\r\n"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500024,
                        CourseDisplayId = 25,
                        Title = "Conclusion",
                        Slug = "oop-conclusion",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Congratulations! You've completed the Intro to Object Oriented Programming course! I hope you have enjoyed the journey. You should now be familiar with the four core principles of OOP. Most importantly you were able to apply this important programming paradigm to a real project." },
                                }
                            },
                            new Block
                            {
                                Title = "What To Do Now",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The first step I recommend is to write down a reflection upon what you've just learned. What did you think of the course? What are sub-topics you still feel you don't understand well? What feels more clear to you now?" },
                                    new Paragraph {
                                       Body = "Right now we recommend you jump back into our projects and apply the knowledge from this course wherever you can. You can revisit this course at any time. Each time you repeat a course, you'll find that you'll learn something new or see the same topic from a new perspective, no matter how many times you do it." },
                                    new Paragraph { Body = "Remember that this is an intro course covering the most used aspects of Object Oriented Programming. We're working on an advanced course, covering topics for students that are already very comfortable the material in this course. Stay tuned! And once again! Congratulations!" }
                                }
                            },
                            new Block
                            {
                                Title = "Video Course",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We also have a paid video version of this tutorial. You have three options to access this course:<br><br>\r\n<b>Option 1</b>: Purchase the course <a href='https://thecsharpschool.getlearnworlds.com/payment?product_id=cshasp-object-oriented-programming-crash-course' target='_blank'>individually for $4.99</a>.<br>\r\n<b>Option 2</b>: Subscribe to the <b>VIP Membership</b> and have access to <a href='https://thecsharpschool.getlearnworlds.com/payment?product_id=the-c-academy-membership&type=subscription' target='_blank'>all our courses for $4.99/month</a><br>\r\n<b>Option 3</b>: Subscribe to the <b>VIP Mentorship</b> for <a href='https://thecsharpschool.getlearnworlds.com/payment?product_id=net-accelerator-mentorship&type=subscription' target='_blank'>all courses and 1-on-1 mentorship for 39.99/month</a>" },
                                }
                            },
                        }
                    }
                }
            },
            new Course
            {
                Id = 2,
                Title = "Azure AI Speech",
                Description = "Master speech capabilities in Azure AI for dynamic, voice-driven applications!",
                Articles = new List<Article>
                {
                    new Article
                    {
                        Id = 500026,
                        CourseDisplayId = 1,
                        Title = "Introduction",
                        Slug = "ai-speech-introduction",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Welcome to our Azure AI Speech course! In this course we will learn about this amazing Azure-powered AI functionality while building a cool project. You should be excited! This course will be an e-eye-opener for the possibilities of AI integration!" }
                                }
                            },
                            new Block
                            {
                                Title = "Who's This Course For?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "This course <b>isn't for absolute beginners in C#</b>. You might struggle if you don't know basic topics such as basic C# syntax (variables, loops, methods, data types, basic data structures, control flow), how to navigate Visual Studio or Visual Studio Code and how to create a console apps, to mention a few. If you're an absolute beginner, <a href='project/53/math-game' target='_blank'>we recommend you go back to this article and build a solid foundation first</a>." },
                                    new Paragraph {
                                       Body = "It's also advisable to have some experience with <b>asynchronous programming</b>. While you don't need to be an expert, Azure Speech APIs provide asynchronous endpoints, so we need to code accordingly. Having zero experience with the <b>\"Task\", \"async\" and \"await\"</b> keywords might pose some challenges. You'll still be able to follow along, but make sure you research the keywords and concepts you haven't seen before." }
                                }
                            },
                            new Block
                            {
                                Title = "What to Expect?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "By the end of this course you should be comfortable using the Azure Speech Services API. Most importantly, you'll understand what this integration is capable of, leading to your own ideas for interesting projects. " },
                                    new Paragraph {
                                       Body = "Basic understanding of how to interact with Azure Speech Services will also give you a foundation for how to interact with other Azure services in your projects. There are similarities across all of these services and you'll be more confident to tackle them on your own." }
                                }
                            },
                             new Block
                            {
                                Title = "AI Building vs AI Integration",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "In this course <b>we won't be building AI systems</b>. Instead we will <b>integrate AI into an app</b>. It's important to make this distinction. Even though both skills are important to learn, they're fundamentally different." },
                                    new Paragraph {
                                       Body = "<b>Building AI</b> involves data collection and preparation, machine or deep learning algorithm development and model training. <b>Integrating AI</b> refers to using existing AI services, libraries, or pre-trained models to add intelligent features to an app." }
                                }
                            },
                             new Block
                            {
                                Title = "What We Recommend",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "<b>Study each chapter carefully</b>. Make quick notes with important observations and remaining doubts. <b>Don't rush through the chapters</b>. Make sure you understand what each key word does. Ask follow-up questions from Chat GPT. Use it as an assistant. Its biggest strength is the ability to explain concepts in different ways in a conversational style." },
                                    new Paragraph {
                                       Body = "Finally, we highly recommend you do <b>at least one of the challenges</b> provided at the end of this course. They'll reinforce your learning and help with knowledge retention. There's nothing quite like building something yourself!" }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500027,
                        CourseDisplayId = 2,
                        Title = "About AI Programming",
                        Slug = "ai-speech-programming",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In the 2020s, the role of an <b>AI engineer</b> has become more crucial than ever, as artificial intelligence continues to reshape industries and change the way we live and work. With AI technologies like machine learning, natural language processing, and computer vision reaching new levels of maturity, businesses are increasingly relying on AI engineers to develop intelligent solutions that drive innovation and competitive advantage. " }
                                }
                            },
                            new Block
                            {
                                Title = "CRUD Isn't Enough",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Gone are the days when it would suffice to know how to implement <b>CRUD operations</b> to survive in the tech Industry. As companies across various sectors, from healthcare to finance, seek to leverage the power of AI for efficiency and insights, the demand for skilled AI engineers is growing rapidly, making it a promising career path for those interested in cutting-edge technology." },
                                    new Paragraph {
                                       Body = "The rise of AI in 2024 lead to transformative changes in the job market, with new opportunities emerging in areas such as autonomous systems, data-driven decision-making, and AI-enhanced software development. AI engineers are not only responsible for creating and maintaining algorithms but also for <b>integrating AI into existing systems</b> to solve complex problems and automate tasks.  With organizations striving to incorporate AI into their business models, AI engineers are positioned to play a key role in shaping the future of work and driving digital transformation." }
                                }
                            },
                            new Block
                            {
                                Title = "How Does it Fit In Your Learning Journey?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Given all these transformations, the best approach to learn programming in our decade is thinking of AI <b>not as a replacement</b> to the current skill set necessary to get into the industry, but as part of it. Engineers still need to know front-end, back-end, SQL and everything else we currently study. AI will purely be part of the tech stack. That's not to mention <b>using AI for learning</b>. LLMs play a crucial role in helping students understand concepts due to its conversational style. Albeit imperfect, studying with the help of an LLM is akin to having a personal instructor available 24/7." },
                                    new Paragraph {
                                       Body = "The great news is that <b>it's all just getting started</b>. The current impact of AI in our lives and in software development is just the tip of the iceberg. If you're getting into the industry now, <b>you're getting in early</b>. And The C# Academy will take you by the hand in your AI pathway with .NET/Azure. You should be excited! Let's open our doors to the future and embark on our AI Journey." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500028,
                        CourseDisplayId = 3,
                        Title = "The Course's Project",
                        Slug = "ai-speech-course-project",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In this course we will create a <b>Coding Tracker</b>. An application that will log the amount of study time and generate reports on these logs. As a programming student, we find it of the most useful applications you can build. When learning, you should have a weekly and monthly goals and compare it to your performance so you can adjust and plan your schedule around your goals. And a great way to do it is developing an app yourself!" },
                                    new Paragraph { Body = "Users will provide input using their voice. The program's output will be via text and voice. These functionalities are powered by <b>Azure Cognitive Services</b>. More specifically, Azure Speech Services. " }
                                },
                            },
                            new Block
                            {
                                Title = "What are Azure Speech Services",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Azure Speech Services is a cloud-based service that provides advanced speech-to-text and text-to-speech capabilities. It enables applications to <b>convert spoken language into written text</b> and synthesize spoken language from text, making interactions with software more natural and accessible. Azure Speech Services supports <b>multiple languages and dialects</b>, and can be integrated with other Azure Cognitive Services for a more comprehensive AI-driven experience." }
                                }
                            },
                            new Block
                            {
                                Title = "Accessibility",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Speech-to-text and text-to-speech are some of the tools that can help developers improve accessibility, a crucial concept in modern software development, as it ensures that applications are usable by <b>people with a range of abilities</b>. Integrating voice input and output can make an application more accessible to those who may have difficulty using traditional input devices like a keyboard or mouse. By embracing accessibility, developers can create <b>inclusive experiences</b> that cater to a broader audience, ensuring that everyone has the opportunity to benefit from technology." }
                                }
                            },
                            new Block
                            {
                                Title = "Why Learn With Projects?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Learning with projects is important because it allows students to apply theoretical knowledge in a <b>practical context</b>. Building real-world applications helps solidify concepts and gives students a sense of accomplishment. Working on projects like the Coding Tracker also exposes learners to <b>common challenges they will face in the industry</b>, such as integrating APIs, handling user input, and implementing accessibility features, preparing them for future development tasks." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500029,
                        CourseDisplayId = 4,
                        Title = "Creating an Azure Account",
                        Slug = "ai-speech-azure-account",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Let's go through the steps to set up a free Azure Account. First navigate to <a href='project/53/math-game' target='_blank'>Azure's Website</a>. If you already have an Azure account, mark this article as read and proceed to the next." },
                                    new Paragraph { Body = "<b>Click on the </b>\"Start free\" button</b> on the homepage. This will guide you to sign up for a free Azure account, which provides credits to use on various Azure services for the first 30 days." },
                                    new Paragraph { Body = "<b>Sign In or Create a Microsoft Account</b>: If you don't have a Microsoft account, you'll need to create one. If you already have one, sign in with your existing credentials." },
                                    new Paragraph { Body = "<b>Provide Basic Information</b>: Fill out the required details, such as your name, email address, and phone number. <b>Verify your identity</b> using a phone number to receive a verification code." },
                                    new Paragraph { Body = "Although you won't be charged if you delete your learning resources after using them, <b>you must provide a credit or debit card for identity verification</b>. Microsoft uses this card to ensure that you're a real person, but <b>you won’t be charged</b> as long as you stay within the free services and credits." },
                                    new Paragraph { Body = "<b>Read the terms and conditions</b> and privacy statement, then accept them." },
                                    new Paragraph { Body = "<b>Complete the Setup</b>: Once the account is set up, you'll get free access to various Azure services and <b>$200 in credit</b> for the first 30 days to explore Azure services." },
                                    new Paragraph { Body = "<b>Once your credits expire</b>, you can still use Azure for learning. You can still use most features for free, as long as you delete the resources once you're done using them." },
                                    new Paragraph { Body = "After completing these steps, you'll have a <b>fully functional Azure account</b> and can start using services like Cognitive Services, Azure Machine Learning, and more." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500030,
                        CourseDisplayId = 5,
                        Title = "Creating a Speech Service",
                        Slug = "ai-speech-creating-service",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In the Azure Console, search for <b>Azure Speech</b>. You'll be taken to the Azure AI Services dashboard. <b>Click on Create</b>." },
                                    new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "tcsa-speech-azure-1.png"
                                    },
                                    new Paragraph { Body = "Choose a Resource Group and a Name For Your Service and <b>Standard S0</b> as your price tier. Click on Review + Create." },
                                    new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "tcsa-speech-azure-2.png"
                                    },
                                    new Paragraph { Body = "Once the resource is created, open a text note and copy and paste your Location/Region value and your Key 1. You'll need those values to connect to the service API." },
                                    new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "tcsa-speech-azure-3.png"
                                    }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500031,
                        CourseDisplayId = 6,
                        Title = "Creating the Course Project",
                        Slug = "ai-speech-creating-project",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Let's start by creating a console application and installing the <b>Microsoft.CognitiveServices.Speech</b> NuGet package. This package is part of Azure's Cognitive Services and provides functionalities for integrating speech-related capabilities into applications. " },
                                    new Paragraph { Body = "Next, in Program.cs, let's implement the following code:" },
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "while (true)\r\n{\r\n    Console.WriteLine(\"What would you like to do?\");\r\n    //collect input\r\n    var menuChoices = MenuChoices.ViewRecords;\r\n\r\n    switch (menuChoices)\r\n    {\r\n        case MenuChoices.ViewRecords:\r\n            {\r\n                ViewRecords();\r\n                break;\r\n            }\r\n        case MenuChoices.AddRecord:\r\n            {\r\n                AddRecord();\r\n                break;\r\n            }\r\n        case MenuChoices.DeleteRecord:\r\n            {\r\n                DeleteRecord();\r\n                break;\r\n            }\r\n        case MenuChoices.CreateReport:\r\n            {\r\n                Report();\r\n                break;\r\n            }\r\n    }\r\n\r\n    Console.WriteLine(\"Waiting for Input\");\r\n}\r\n\r\nvoid ViewRecords()\r\n{\r\n\r\n}\r\n\r\nvoid AddRecord()\r\n{\r\n\r\n}\r\n\r\nvoid DeleteRecord()\r\n{\r\n\r\n}\r\n\r\nvoid Report()\r\n{\r\n\r\n}\r\n\r\npublic enum MenuChoices\r\n{\r\n    ViewRecords,\r\n    AddRecord,\r\n    DeleteRecord,\r\n    CreateReport\r\n}"
                                    },
                                    new Paragraph { Body = "This code has a simple menu of choices. Users will be able to add, delete and view coding records. Powering the menu is a switch statement based on an <b>Menu Choices enum</b> (at the end of the file). The switch runs inside a loop so it keeps running after each operation. The call to collect the voice input will be after the <b>What would you like to do?</b> message. The operations will be handled by methods that can be found after the loop." },
                                }
                            }
                        }
                    },
                }
            },
            new Course
            {
                Id = 3,
                Title = "Introduction to ASP.NET Core Web APIs",
                Description = "Master speech capabilities in Azure AI for dynamic, voice-driven applications!",
                ImgUrl = "icons8-internet-64.png",
                Articles = new List<Article>
                {
                    new Article
                    {
                        Id = 500050,
                        CourseDisplayId = 1,
                        Title = "Introduction",
                        Slug = "asp-net-core-webapi-introduction",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Welcome to the ASP.NET Core Web APIs Course for Beginners! We are thrilled to have you join us on this exciting course, designed to provide you with a comprehensive introduction to  building robust and scalable Web APIs." },
                                    new Paragraph {
                                       Body = "<b>Web APIs are the backbone of modern web applications</b>. They allow different systems to communicate and exchange data, enabling rich, dynamic user experiences. Understanding how to build and interact with Web APIs is crucial for creating modern web applications that are responsive and scalable." },
                                    new Paragraph
                                    {
                                        IsPicture = true,
                                        PictureUrl = "c3-ch1-webapis-flight-api-banner.png"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "What are We APIs?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Web APIs, or <b>Web Application Programming Interfaces</b>, are sets of rules and protocols that allow different software applications to communicate with each other over the internet. They serve as intermediaries, enabling applications to request and exchange data seamlessly." },
                                    new Paragraph {
                                       Body = "In simple terms, when you think about a Web API, imagine it as <b>a bridge between two applications</b>. For instance, when you use a weather app on your smartphone, the app communicates with a web service that provides weather data. This communication happens through a Web API. The app <b>sends a request</b> to the API, which then fetches the weather data from a database and sends it back to the app in a structured format." },
                                    new Paragraph {
                                       Body = "Web APIs use standard web protocols like <b>HTTP/HTTPS</b> for communication, making them <b>accessible via URLs</b>. They typically handle requests and responses in formats such as JSON or XML, which are easy for both humans and machines to read and process." },
                                }
                            },
                            new Block
                            {
                                Title = "Modern Web",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "All major platforms you use every day, such as Google, Facebook, Twitter, Instagram, Discord, Reddit and online games offer Web APIs that allow third-party developers to <b>integrate their services</b> into other applications. This means you can see integrations with these serves from on a variety of platforms, not just on the original website or app." },
                                    new Paragraph {
                                       Body = "In essence, Web APIs are crucial for creating <b>interconnected systems</b> where different applications can work together, share data, and enhance functionality. <b>They are the foundation of the modern web</b>, enabling the creation of complex, dynamic, and integrated digital experiences." }
                                }
                            },
                            new Block
                            {
                                Title = "Who's this course for? ",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "➡️<b>Beginners</b>: Those who already know a little C# and want to build a solid foundation in ASP.NET Core. However if this is your first time with the language, this course isn't for you. You should try The C# Foundations Course first." },
                                    new Paragraph {
                                       Body = "➡️<b>Developers</b>: Individuals with some programming experience looking to expand their skill set into web APIs." },
                                     new Paragraph {
                                       Body = "➡️<b>Students</b>: Learners who are studying computer science or related fields and need practical experience with web technologies." },
                                    new Paragraph {
                                       Body = "This course is <b>not for absolute beginners</b> in C#. If you're still learning the basics, we recommend you follow our roadmap <a href='project/53/math-game' target='_blank'>starting from this project</a>." },
                                }
                            },
                            new Block
                            {
                                Title = "What You'll Learn",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Throughout this course, you will:<br>☑️\r\n<b>Understand the Basics</b>: Get acquainted with the fundamental concepts of ASP.NET Core Web APIs and RESTful services.<br>☑️\r\n<b>Set Up Your Development Environment</b>: Learn how to install and configure the tools you need to build ASP.NET Core applications.<br>☑️\r\n    <b>Create Your First Web API</b>: Step-by-step guidance on creating a simple yet functional Web API from scratch.<br>☑️\r\n     <b>Routing and Controllers</b>: Dive deep into routing mechanisms and how controllers handle HTTP requests.<br>☑️\r\n     <b>Work with Data</b>: Connecting to databases using Entity Framework Core.<br>☑️\r\n     <b>Implement CRUD Operations</b>: Master the essential Create, Read, Update, and Delete operations in your API.<br>☑️\r\n     <b>Testing</b>: Testing Web APIs with the industry-standard Postman tool\r\n" }
                                }
                            },
                            new Block
                            {
                                Title = "Course Structure",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "As with all tutorials in the academy, this course is practical. We'll learn while developing a Flight Data API, tracking information about aiports, planes and seats. It's a great complex real world application that will provide the right complex to learn about Web APIs." },
                                    new Paragraph {
                                       Body = "At the end of each lesson that contains new code, you'll see a link to the branch in the project's Github repository, containing the code for the current stage of the project." }
                                }
                            },
                             new Block
                            {
                                Title = "Video Course",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We also have a paid video version of this tutorial. The video version already contains a part 2, with the intermediate content.:<br><br>\r\n<b>Option 1</b>: Purchase the course <a href='https://thecsharpschool.getlearnworlds.com/course/aspnet-core-web-apis' target='_blank'>individually for $4.99</a>.<br>\r\n<b>Option 2</b>: Subscribe to the <b>VIP Membership</b> and have access to <a href='https://thecsharpschool.getlearnworlds.com/payment?product_id=the-c-academy-membership&type=subscription' target='_blank'>all our courses for $4.99/month</a><br>\r\n<b>Option 3</b>: Subscribe to the <b>VIP Mentorship</b> for <a href='https://thecsharpschool.getlearnworlds.com/payment?product_id=net-accelerator-mentorship&type=subscription' target='_blank'>all courses and 1-on-1 mentorship for 39.99/month</a>" }
                                }
                            },
                        }
                    },
                    new Article
                    {
                        Id = 500051,
                        CourseDisplayId = 2,
                        Title = "Creating the Project",
                        Slug = "asp-net-core-webapi-project",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Let's start by creating our project. In Visual Studio, choose the ASP.NET Core Web API option. We're calling it TCSA.WebAPIs.FlightsData. Feel free to choose another name if you'd like. In the screen that follows you can keep all default configurations, but untick 'Create Controllers'. That will create a Minimal API as a starting point. We will see what that means later." +
                                    "" },
                                    new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "c3-ch2-webapis-coursecreation.png"
                                    },
                                    new Paragraph { Body = "Once your project is created, you'll see the following folders and files:" },
                                    new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "c3-ch2-webapis-project-template.png"
                                    },
                                },
                            },
                            new Block
                            {
                                Title = "Examine The Project Files",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "The template generated upon project creation is a Minimal API that serves data about the weather. This is what each file does:" },
                                    new Paragraph {
                                       Body = "➡️ <b>Program.cs:</b> Serves as the entry point and main configuration file for the application. Configures the web application, adds services such as Swagger for API documentation, sets up middleware, and defines endpoints."
                                    },
                                    new Paragraph {
                                       Body = "➡️ <b>appsettings.json</b>: Stores configuration settings for the application.  Initially contains logging configuration and allowed hosts."
                                    },
                                    new Paragraph {
                                       Body = "➡️ <b>appsettings.Development.json</b> :  Overrides settings in appsettings.json when the application runs in the development environment."
                                    },
                                    new Paragraph {
                                       Body = "➡️ <b>launchsettings.json</b> : Typically found in the Properties folder. Defines profiles for launching the application in different environments (e.g., development, production). Specifies the environment variables, command-line arguments, and other settings for running the application."
                                    },
                                    new Paragraph {
                                       Body = "➡️ <b>TCSA.WebAPI.FlightData.http:</b>  Used for testing API endpoints directly from within the code editor, often Visual Studio Code, which supports HTTP request files through extensions like REST Client. It allows developers to send HTTP requests to their API without needing to use external tools. However, in this tutorial we will use Postman for testing our endpoints."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Clean Up",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Let's convert our project from a Minimal API to a Controller-Based Web API. In Program.cs, start by removing the following snippets."
                                    },
                                    new Paragraph {
                                        IsCode = true,
                                       Body = "app.UseHttpsRedirection();\r\nvar summaries = new[]\r\n{\r\n    \"Freezing\", \"Bracing\", \"Chilly\", \"Cool\", \"Mild\", \"Warm\", \"Balmy\", \"Hot\", \"Sweltering\", \"Scorching\"\r\n};\r\n\r\napp.MapGet(\"/weatherforecast\", () =>\r\n{\r\n    var forecast = Enumerable.Range(1, 5).Select(index =>\r\n        new WeatherForecast\r\n        (\r\n            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),\r\n            Random.Shared.Next(-20, 55),\r\n            summaries[Random.Shared.Next(summaries.Length)]\r\n        ))\r\n        .ToArray();\r\n    return forecast;\r\n})\r\n.WithName(\"GetWeatherForecast\")\r\n.WithOpenApi();\r\n\r\ninternal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)\r\n{\r\n    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);\r\n}\r\n"
                                    },
                                    new Paragraph {
                                       Body = "Upon cleaning up, we will add two lines to support the use of controller. You can see them in the commented lines below. After the modifications your file should look like this:"
                                    },
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "var builder = WebApplication.CreateBuilder(args);\r\n\r\nbuilder.Services.AddEndpointsApiExplorer(); //swagger\r\nbuilder.Services.AddSwaggerGen(); // swagger\r\nbuilder.Services.AddControllers(); //added code \r\n\r\nvar app = builder.Build();\r\n\r\nif (app.Environment.IsDevelopment())\r\n{\r\n    app.UseSwagger();\r\n    app.UseSwaggerUI();\r\n}\r\n\r\napp.MapControllers(); //added code\r\n\r\napp.Run();\r\n"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Program.cs explained",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Let's see what the code in <b>Program.cs</b> is doing:" },
                                    new Paragraph {
                                       Body = "<b>In line 1</b>, we create an instance of the <b>WebApplicationBuilder</b> class. This class is part of the new minimal API feature introduced in ASP.NET Core 6, which provides a simplified way to create lightweight web applications, particularly for building APIs." },
                                    new Paragraph {
                                       Body = "<b>In line 5</b>, builder.Services.AddControllers() sets up the necessary infrastructure for <b>handling HTTP requests</b> with controllers in an ASP.NET Core application. It's a critical step in configuring the application's behavior and enabling the implementation of RESTful APIs or web endpoints." },
                                     new Paragraph {
                                       Body = "<b>In line 15</b>, app.MapControllers() sets up routing and request handling. It integrates with the framework's routing and <b>middleware infrastructure</b> to provide a mechanism for building web APIs and web applications." },
                                     new Paragraph {
                                       Body = "<b>In lines 3,4 and 9 to 13</b> we can see the registration and configuration of Swagger, a UI that facilitates testing ASP.NET Core Web APIs without the need for external apps." },
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "You can find the code for the current state of this project <a href='https://github.com/TheCSharpAcademy/TCSA.Course.WebAPI.FlightData/tree/1.Creating-Project' target='_blank'>in this link</a>." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500052,
                        CourseDisplayId = 3,
                        Title = "Minimal APIs",
                        Slug = "asp-net-core-minimal-apis",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "When we created our project, we've chosen to untick the 'Add Controllers' box. This means that the initial template provided was for a <b>Minimal API</b> instead of traditional ASP.NET Core Web API." }
                                }
                            },
                            new Block
                            {
                                Title = "How are They Different?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Minimal APIs and traditional APIs in C# differ primarily in their structure and design philosophy. Minimal APIs, introduced in .NET 6, aim to simplify API development by <b>reducing boilerplate code</b>. They enable developers to create API endpoints with minimal configuration, often using a single file to define routes, services, and middleware. This approach contrasts with traditional APIs, where the use of controllers, multiple files, and a more layered architecture is common. The goal of minimal APIs is to speed up development, making it more accessible for <b>small projects or microservices that don't require the full features</b> of traditional ASP.NET Core."}
                                }
                            },
                            new Block
                            {
                                Title = "Traditional APIs",
                                Paragraphs = new List<Paragraph>
                                {
                                      new Paragraph { Body = "In traditional APIs, controllers are used to group related actions together, following the <b>Model-View-Controller (MVC)</b> pattern. Each controller inherits from <b>ControllerBase</b>, and routing is conventionally handled using attributes on methods. This approach offers a well-structured way to <b>separate concerns</b> and manage complex applications, making it <b>suitable for larger projects</b> where organization and modularity are key. Traditional APIs also support a rich set of features out of the box, such as model binding, validation, and filters, which help manage concerns like error handling and authorization." }
                                }
                            },
                            new Block
                            {
                                Title = "Minimal APIs",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Minimal APIs, on the other hand, take a more functional approach, allowing developers to define routes <b>directly in the Program.cs</b> file or similar entry points. The use of <b>lambda expressions</b> for defining endpoints makes the syntax concise, but may sacrifice some of the organization and readability found in traditional controllers. Since minimal APIs do not rely on the MVC pattern, they are less opinionated about the application's structure, giving developers the freedom to set up the project as needed. This flexibility comes at the cost of some built-in features, though it is possible to manually add these as needed." }
                                }
                            },
                            new Block
                            {
                                Title = "Which One Should You Choose?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "The decision to use minimal APIs or traditional APIs ultimately <b>depends on the project's requirements</b>. Minimal APIs are well-suited for simple or microservice-based applications, where rapid development and minimal configuration are priorities. In contrast, traditional APIs are a better choice for larger, enterprise-level applications where a more robust architecture and advanced features are necessary. It's important to notice that <b>both approaches can be present within the same application</b>, allowing developers to choose the appropriate style for different components of the project." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500053,
                        CourseDisplayId = 4,
                        Title = "Installing Entity Framework",
                        Slug = "asp-net-core-minimal-ef-core",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Entity Framework (EF) is an <b>Object-Relational Mapper (ORM)</b> that allows .NET developers to work with a database using <b>C# objects</b>. It eliminates the need for most of the data-access code that developers usually need to write. ASP.NET Core is a cross-platform, high-performance framework for building modern, cloud-based, internet-connected applications. When used together, Entity Framework Core and ASP.NET Core provide a powerful stack for building RESTful APIs. If you've never used Entity Framework before, we recommend you go through our <a href='https://www.thecsharpacademy.com/project/16/phonebook' target='_blank'>phone book project</a> to get acquainted. Learning EF and Web APIs at the same time might be overwhelming." }
                                }
                            },
                            new Block
                            {
                                Title = "EF in Our Curriculum",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In the C# Academy curriculum we use ADO.NET in the \r\n<a href='https://www.thecsharpacademy.com/project/12/habit-logger' target='_blank'>Habit Logger</a> and Dapper in the \r\n<a href='https://www.thecsharpacademy.com/project/13/coding-tracker' target='_blank'>Coding Tracker</a> projects, before learning EF in the Phone Book app. This is because ADO.NET and Dapper give you more exposure to SQL, the language ultimately used by all data access solutions to communicate with databases."}
                                }
                            },
                            new Block
                            {
                                Title = "Sqlite",
                                Paragraphs = new List<Paragraph>
                                {
                                      new Paragraph { Body = "In this project we will use the <b>Sqlite database engine</b>. SQLite is a self-contained, serverless, zero-configuration, transactional SQL database engine. It is widely used for its simplicity and efficiency, making it an excellent choice for embedded systems, mobile applications, and small to medium-sized projects. Unlike traditional database management systems that require a separate server process, SQLite operates through a <b>single library that interacts directly with the database file</b>, which simplifies setup and administration, making it ideal for our course." },
                                      new Paragraph { Body = "SQLite stores the entire database, including tables, indexes, and the data itself, <b>in a single file</b>, enhancing portability and ease of use. It supports most of the SQL standard, including transactions, joins, views, and triggers, providing rich functionality without the overhead of a more complex system." }
                                },
                            },
                            new Block
                            {
                                Title = "NuGet Packages",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "To use EF in our project we've installed the following packages:<br>➡️<b>Microsoft.EntityFrameworkCore.Design</b>: Provides design-time tools for scaffolding and migrations.<br>➡️<b>Microsoft.EntityFrameworkCore.Sqlite</b>: Enables the use of SQLite as the database engine in EF Core.<br>➡️<b>Microsoft.EntityFrameworkCore.Tools</b>: Includes command-line tools for managing database migrations and schema updates." }
                                }
                            },
                            new Block
                            {
                                Title = "In a new folder called Data, create a new class called FlightsDbContext with the following code:",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "public class FlightsDbContext: DbContext\r\n    {\r\n        public FlightsDbContext(DbContextOptions options) : base(options)\r\n        {\r\n            \r\n        }\r\n    }" },
                                    new Paragraph {
                                       Body = "<b>FlightsDbContext : DbContext</b>. This means our class inherits from DbContext class, which is part of the EF Core library and represents a session with the database, enabling querying and saving of data." },
                                    new Paragraph {
                                       Body = "<b>public FlightsDbContext(DbContextOptions options) : base(options)</b>. This is a constructor for the FlightsDbContext class. It takes a parameter of type DbContextOptions and passes it to the base class constructor (DbContext) using the <b>base(options)</b> call. This means we're implementing the constructor of the class we're inherting from." },
                                     new Paragraph {
                                       Body = "<b>DbContextOptions Parameter</b>: This class is used to configure the DbContext. It typically includes settings such as the database provider, connection string, and other configuration options." },
                                    new Paragraph {
                                       Body = "The call to <b>base(options)</b> in the constructor is crucial. It passes the configuration options up to the DbContext base class so that the EF Core can use these options to <b>set up the database context </b>appropriately." }
                                },
                            },
                            new Block
                            {
                                Title = "Program.cs",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "var builder = WebApplication.CreateBuilder(args);\r\n\r\nbuilder.Services.AddEndpointsApiExplorer();\r\nbuilder.Services.AddSwaggerGen();\r\nbuilder.Services.AddControllers();\r\n\r\n//NEW \r\nbuilder.Services.AddDbContext&lt;FlightsDbContext&gt(opt => opt.UseSqlite(builder.Configuration.GetConnectionString(\"DefaultConnection\")));\r\n\r\nvar app = builder.Build();\r\n\r\nif (app.Environment.IsDevelopment())\r\n{\r\n    app.UseSwagger();\r\n    app.UseSwaggerUI();\r\n}\r\n\r\napp.MapControllers();\r\n\r\napp.Run();" },
                                    new Paragraph {
                                       Body = "<b>AddDbContext()</b> adds the FlightsDbContext to the <b>Dependency Injection container</b>, making it available for injection into controllers and other services where it’s needed." },
                                     new Paragraph {
                                       Body = "<b>opt => opt.UseSqlite(...):</b> This part is a lambda expression used to configure options for the FlightsDbContext class. The opt parameter represents an instance of DbContextOptionsBuilder, which we've seen when creating the context." },
                                      new Paragraph {
                                       Body = "<b>UseSqlite()</b> configures FlightsDbContext to use SQLite as its database provider, using the connection string obtained in <b>appsettings.json</b>" },
                                       new Paragraph {
                                       Body = "With this in place we have everything we need to start creating our API with the help of EF Core!" }
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "You can find the code for the current state of this project <a href='https://github.com/TheCSharpAcademy/TCSA.Course.WebAPI.FlightData/tree/2.Installing-Entity-Framework' target='_blank'>in this link</a>." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500054,
                        CourseDisplayId = 5,
                        Title = "Code-First Approach",
                        Slug = "ef-core-code-first",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "EF Core follows a <b>code-first approach</b>, where you define your <b>data model</b> using C# classes (your entity classes) and then generate the corresponding database schema from those classes. When you <b>run a migration</b>, Entity Framework Core compares the current state of your entity classes to the previous state (recorded in the migration history) to determine what changes need to be made to the database schema to bring it in sync with the current state of your entity classes." },
                                    new Paragraph { Body = "An alternative would be the <b>database-first approach</b> where you begin with an existing database schema that has been designed and implemented independently of EF Core." }
                                },

                            },
                            new Block
                            {
                                Title = "DbSet",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        Body = "In our DbContext we will use a <b>DbSet&lt;T&gt</b> class <b>(line 8)</b>, which is used for interactions with the database. The use of 'T' indicates a <b>generic type</b> parameter that allows DbSet to work with any specific type of entity in a strongly-typed manner. In this case we will be working with the <b>Flight</b> custom type we'll define next."
                                    },
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "public class FlightsDbContext: DbContext\r\n    {\r\n        public FlightsDbContext(DbContextOptions options) : base(options)\r\n        {\r\n            \r\n        }\r\n\r\n        public DbSet&lt;Flight&gt Flights { get; set; }\r\n    }"
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Flight Model",
                                Paragraphs = new List<Paragraph>
                                {
                                      new Paragraph { Body = "Next create a class called Flight inside a new folder called Models, with the following code:" },
                                      new Paragraph {
                                          IsCode = true,
                                          Body = "public class Flight\r\n{\r\n    public int Id { get; set; }\r\n    public int FlightNumber { get; set; }\r\n    public string AirlineName { get; set; } = string.Empty;\r\n    public string DepartureAirportCode { get; set; } = string.Empty;\r\n    public string ArrivalAirportCode { get; set; } = string.Empty;\r\n    public DateTime DepartureDateTime { get; set; }\r\n    public DateTime ArrivalDateTime { get; set; }\r\n    public int PassengerCapacity { get; set; }\r\n}"
                                      },
                                       new Paragraph { Body = "This class represents a <b>flight in the database</b>, and each of these properties correspond to a column in the Flights table." },
                                        new Paragraph { Body = "If you've never used a Model before in C#, we recommend <a href='https://www.thecsharpacademy.com/course/1/article/0/0/false' target='_blank'>you do our Object Oriented Programming Crash Course</a> first. You might need to close some knowledge gaps before learning about Web APIs." },
                                },
                            },
                            new Block
                            {
                                Title = "String.Empty",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Initializing strings with <b>string.Empty</b> instead of null or an empty string literal (\"\") offers several benefits. First, it provides clarity and intent, making it explicit that the string is intended to be empty, which enhances code readability and reduces ambiguity. Second, it establishes consistency across the codebase, making the code easier to understand and maintain. Third, it helps avoid null reference exceptions by ensuring that the string reference is never null, making the code more reliable." }
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "You can find the code for the current state of this project <a href='https://github.com/TheCSharpAcademy/TCSA.Course.WebAPI.FlightData/tree/3.Code-First-Approach' target='_blank'>in this link</a>." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500055,
                        CourseDisplayId = 6,
                        Title = "First Migration",
                        Slug = "ef-core-first-migration",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "A migration in EF Core is a way to apply incremental changes to your database schema based on changes to your data model. Migrations allow you to evolve your database schema over time, <b>keeping it in sync with the application’s data model</b> while preserving the existing data." },
                                    new Paragraph { Body = "They provide a systematic and controlled way to manage database schema changes over the lifecycle of an application. By capturing and applying schema changes incrementally, migrations help ensure that the database remains coherent with the code changes, supporting ongoing development and deployment processes" }
                                },

                            },
                            new Block
                            {
                                Title = "Entity Framework Command Line Tool",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        Body = "The command-line tool is a utility that assists with managing EF Core tasks in .NET projects. It specifically helps with tasks related to database schema management and migrations, from the command line."
                                    },
                                    new Paragraph {
                                        Body = "This is the tool of choice for Visual Studio Code users. Visual Studio programmers can also use the command line tool but have the option to use the <b>NuGet Package Manager Console</b>. Keep in mind that the commands differ from one to the other."
                                    },
                                    new Paragraph {
                                        Body = "If using the command line, run the following commands to install the tool, add your first migration inside a <b>Data/Migrations</b> directory and update the database accordingly."
                                    },
                                    new Paragraph {
                                          IsCode = true,
                                          Body = "dotnet tool install dotnet-ef --global\r\ndotnet ef migrations add InitialCreate -o Data/Migrations\r\ndotnet ef database update"
                                      },
                                     new Paragraph {
                                        Body = "If using the Package Manager in Visual Studio, run the following commands."
                                    },
                                    new Paragraph {
                                          IsCode = true,
                                          Body = "Add-Migration InitialCreate\r\nUpdate-Database"
                                      },
                                    new Paragraph {
                                        Body = "When running your first migration you'll see the following code in the terminal:"
                                    },
                                    new Paragraph {
                                          IsPicture = true,
                                          PictureUrl = "c3-ch6-webapis-migration.png"
                                      },
                                     new Paragraph {
                                        Body = "This is because EF commands ultimately <b>translate into SQL</b>. When you run a migration command (such as dotnet ef database update), EF Core logs the SQL commands being executed against the database. This helps you understand what changes are being applied to the database schema and troubleshoot any issues that may arise during migration execution."
                                    },
                                }
                            },
                            new Block
                            {
                                Title = "Migration Files",
                                Paragraphs = new List<Paragraph>
                                {
                                      new Paragraph { Body = "Upon creating our migration, the following files were generated:" },
                                      new Paragraph {
                                          IsPicture = true,
                                          PictureUrl = "c3-ch6-webapis-migration-files-db.png"
                                      },
                                       new Paragraph { Body = "<b>These auto-generated files should be left alone</b>. Editing this file manually can lead to inconsistencies between your code and the database schema. EF Core uses the information in these to generate SQL scripts for applying and rolling back migrations. About these files:" },
                                        new Paragraph {
                                       Body = "➡️ <b>20241027111757_initial:</b> Contains C# code representing the migration. The name of the file is a combination of the the migration's name and the timestamp of the moment of its creation."
                                    },
                                    new Paragraph {
                                       Body = "➡️ <b>FlightsDbContextModelSnapshot</b>: Captures the current state of the data model."
                                    }
                                },
                            },
                            new Block
                            {
                                Title = "Database File",
                                Paragraphs = new List<Paragraph>
                                {
                                      new Paragraph { Body = "In the picture above we can also see a <b>Flights.db</b> file. This is an Sqlite database file. You can visualise its contents using an external app such as <a href='https://www.thecsharpacademy.com/course/1/article/0/0/false' target='_blank'>DB Browser</a>." },
                                      new Paragraph { Body = "Then open the file using Db Browser. You should see the created tables:" },
                                      new Paragraph {
                                          IsPicture = true,
                                          PictureUrl = "c3-ch6-webapis-db-file.png"
                                      },
                                       new Paragraph { Body = "Examine the Flight table's columns. The <b>__EFMigrationsHistory</b> table simply keeps a history of the migrations." }
                                },
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "You can find the code for the current state of this project <a href='https://github.com/TheCSharpAcademy/TCSA.Course.WebAPI.FlightData/tree/3.Code-First-Approach' target='_blank'>in this link</a>." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500056,
                        CourseDisplayId = 7,
                        Title = "Flight Service",
                        Slug = "web-api-flight-service",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In ASP.NET Core, a service is a class that will be <b>available throughout the application's lifetime</b>. Services in ASP.NET Core are typically added using <b>dependency injection (DI)</b>, allowing you to inject them where needed, which makes the code modular and testable." }
                                },

                            },
                            new Block
                            {
                                Title = "Dependency Inversion",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        Body = "An <b>interface</b> in programming is a way to define a contract or a set of rules that a class must follow. It's like a blueprint for classes, specifying what methods should be implemented, but typically it doesn't provide the implementation details itself. If you haven't worked with C# interfaces before, we recommend <a href='https://www.thecsharpacademy.com/course/1/article/0/0/false' target='_blank'>you do our Object Oriented Programming Crash Course</a>."
                                    },
                                    new Paragraph {
                                        Body = "Although <a href='https://stackoverflow.com/questions/6802573/interfaces-whats-the-point' target='_blank'>there's a lot of debate about the necessity and importance of using interfaces</a>, it can't be disputed that they are an important part of C# design, being applied in several design patterns. In our app we will be using the <b>Dependency Inversion Principle (DIP)</b>, which is one of the five <b>SOLID principles</b> of object-oriented programming."
                                    },
                                    new Paragraph {
                                        Body = "The DIP states that <b>high-level modules should not depend on low-level modules</b>, but both should depend on abstractions. In your example, FlightService depends on the abstraction provided by the IFlightService interface rather than directly on concrete implementations."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "IFlightService",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Let's create a new class called FlightService, inside a new <b>Services folder</b>. Above the class declaration, declare the following interface:" },
                                      new Paragraph {
                                          IsCode = true,
                                          Body = "public interface IFlightService\r\n    {\r\n        public List&lt;Flight&gt GetAllFlights();\r\n        public Flight? GetFlightById(int id);\r\n        public Flight CreateFlight(Flight flight);\r\n        public Flight UpdateFlight(int id, Flight updatedFlight);\r\n        public string? DeleteFlights(int id);\r\n    }" },
                                       new Paragraph { Body = "This interface <b>serves as a contract</b> defining the functionality that any class implementing IFlightService must provide. It allows for different implementations of flight-related services while ensuring consistency in the methods exposed by those implementations. In this specific case, we're using methods for executing <b>CRUD (Create, Read, Update, Delete) operations</b> against a data table. " }
                                },
                            },
                             new Block
                            {
                                Title = "Flight Service",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Now let's declare that FlightService inherits from the interface. Modify FlightService using the following:"
                                    },
                                     new Paragraph {
                                         IsCode = true,
                                         Body = "    public class FlightService : IFlightService\r\n    { \r\n        private readonly FlightsDbContext _dbContext;\r\n\r\n        public FlightService(FlightsDbContext dbContext)\r\n        {\r\n            _dbContext = dbContext;\r\n        }\r\n    }" },
                                     new Paragraph {
                                       Body = "In this snippet we're using Dependency Injection. DbContext is <b>injected via the constructor</b>, making it available for any method in the scope of the class."
                                    },
                                },
                            },
                            new Block
                            {
                                Title = "Service Registration",
                                Paragraphs = new List<Paragraph>
                                {
                                      new Paragraph { Body = "In Program.cs, let's register FlightService in the <b>Dependency Injection Container</b>, in line 7:" },
                                      new Paragraph {
                                          IsCode = true,
                                          Body = "var builder = WebApplication.CreateBuilder(args);\r\n\r\nbuilder.Services.AddEndpointsApiExplorer();\r\nbuilder.Services.AddSwaggerGen();\r\nbuilder.Services.AddControllers();\r\nbuilder.Services.AddDbContext<FlightsDbContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString(\"DefaultConnection\")));\r\nbuilder.Services.AddScoped&lt;IFlightService, FlightService&gt();\r\n\r\nvar app = builder.Build();\r\n" },
                                },
                            },
                             new Block
                            {
                                Title = "Service Lifetimes",
                                Paragraphs = new List<Paragraph>
                                {
                                      new Paragraph { Body = "When registering our FlightService, we are using the <b>AddScoped</b> method. Let's have a quick look at Service Lifetimes in ASP.NET Core:" },
                                      new Paragraph { Body = "➡️ <b>Scoped (AddScoped)</b>: A new instance of the service is created once per request within the scope. In a web application, a scope is typically a single HTTP request." },
                                      new Paragraph { Body = "➡️ <b>Singleton (AddSingleton)</b>: A single instance of the service is created and shared throughout the application's lifetime." },
                                      new Paragraph { Body = "➡️ <b>Transient (AddTransient)</b>: A new instance of the service is created each time it is requested." },
                                      new Paragraph { Body = "<b>Scoped lifetime is recommended for Entity Framework (EF) DbContext</b> in ASP.NET Core applications primarily to ensure that the DbContext instance is <b>used within a single request</b> and disposed of properly after the request is completed. This ensures proper resource management, prevents concurrency issues, and leverages EF's change tracking and caching mechanisms efficiently." },
                                },
                            },
                             new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "You can find the code for the current state of this project <a href='https://github.com/TheCSharpAcademy/TCSA.Course.WebAPI.FlightData/tree/4.Flight-Service' target='_blank'>in this link</a>." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500057,
                        CourseDisplayId = 8,
                        Title = "Service Implementation",
                        Slug = "web-api-service-implementation",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                     new Paragraph { Body = "In FlightsService, under the constructor, let's implement the method for creation of a flight:" },
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "public Flight Createflight(Flight flight)\r\n    {\r\n        var savedFlight = Context.Flights.Add(flight);\r\n        Context.SaveChanges();\r\n        return savedFlight.Entity;\r\n    }"
                                    },
                                    new Paragraph { Body = "In CreateFlight we're adding a flight to the table. The <b>Add() method</b> adds the entity to the context, but it doesn't immediately send the command to the database. Instead, it stages the entity to be added to the database when <b>SaveChanges</b> is called. The object returned by this operation is <b>EntityEntry&lt;Flight&gt</b> and represents the entity (Flight) being tracked by the DbContext. It provides access to information about the entity and its state within the context. This includes properties such as Entity, which represents the entity itself, and various methods and properties for working with the entity's state, tracking changes, etc." },
                                },

                            },
                            new Block
                            {
                                Title = "Delete Flights",
                                Paragraphs = new List<Paragraph>
                                {
                                      new Paragraph {
                                          IsCode = true,
                                          Body = "public string? DeleteFlight(int id)\r\n    {\r\n        Flight savedFlight = Context.Flights.Find(id);\r\n\r\n        if (savedFlight == null)\r\n        {\r\n            return null;\r\n        }\r\n\r\n        Context.Flights.Remove(savedFlight);\r\n\r\n        return $\"Successfully deleted flight with id: {id}\";\r\n    }" },
                                       new Paragraph { Body = "When deleting a flight we first check if it exists. If it doesn't we return null and let the caller deal with it. We then return a meaningful message in case the operation is successful." }
                                },
                            },
                             new Block
                            {
                                Title = "Get All Flights",
                                Paragraphs = new List<Paragraph>
                                {
                                     new Paragraph {
                                         IsCode = true,
                                         Body = "public List<Flight> GetFlights()\r\n    {\r\n        return Context.Flights.ToList();\r\n    }" },
                                     new Paragraph {
                                       Body = "This implementation is self-explanatory. However, it's important to note that calling ToList() in GetAllFlights executes the query <b>immediately and loads all data into memory</b>, which might not be efficient for large datasets. We'll show how to deal with issue later in the course"
                                    },
                                },
                            },
                             new Block
                            {
                                Title = "Get Flight by Id",
                                Paragraphs = new List<Paragraph>
                                {
                                     new Paragraph {
                                         IsCode = true,
                                         Body = "public Flight? GetFlightById(int id)\r\n    {\r\n        Flight savedFlight = Context.Flights.Find(id);\r\n        return savedFlight == null ? null : savedFlight;\r\n    }" },
                                     new Paragraph {
                                       Body = "Here we're looking for a Flight with the id provided. We use a <b>ternary expression</b> to return null if no flight was found and return the flight object if it was found."
                                    },
                                },
                            },
                            new Block
                            {
                                Title = "Update Flight",
                                Paragraphs = new List<Paragraph>
                                {
                                      new Paragraph {
                                          IsCode = true,
                                          Body = "public Flight Updateflight(Flight flight)\r\n    {\r\n        Flight savedFlight = Context.Flights.Find(flight.Id);\r\n\r\n        if (savedFlight == null)\r\n        {\r\n            return null;\r\n        }\r\n\r\n        Context.Entry(savedFlight).CurrentValues.SetValues(flight);\r\n        Context.SaveChanges();\r\n\r\n        return savedFlight;\r\n    }" },
                                       new Paragraph {
                                           Body = "Similarly to GetFlightById(), we're looking for a flight with the given id, returning null if none is found. <b>Context.Entry(savedFlight)</b> gets the DbEntityEntry for savedFlight, which represents its entry in the Entity Framework context. <b>CurrentValues.SetValues(flight)</b> copies the properties from the provided flight object into savedFlight. Essentially, this line takes all values from flight and updates savedFlight with those values."
                                       },
                                },
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "You can find the code for the current state of this project <a href='https://github.com/TheCSharpAcademy/TCSA.Course.WebAPI.FlightData/tree/4.Flight-Service' target='_blank'>in this link</a>." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500058,
                        CourseDisplayId = 9,
                        Title = "Flights Controller",
                        Slug = "web-api-controller",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In ASP.NET Core Web API, controllers are essential components that <b>handle incoming HTTP requests and generate responses</b>. They are part of the MVC (Model-View-Controller) architecture, where they serve as the \"C\" or the controller layer. A controller class is typically derived from ControllerBase and decorated with attributes to define routes and actions." },
                                },
                            },
                            new Block
                            {
                                Title = "Flights Controller",
                                Paragraphs = new List<Paragraph>
                                {
                                     new Paragraph {
                                         Body = "In a new <b>Controllers folder</b> create a <b>FlightsController</b> class with the following code:"
                                     },
                                      new Paragraph {
                                          IsCode = true,
                                          Body = "    [ApiController]\r\n    [Route(\"api/[controller]\")]\r\n    //example: http://localhost:5609/api/flight/\r\n    public class FlightController : ControllerBase\r\n    {\r\n        private readonly IFlightService _flightService;\r\n        public FlightController(IFlightService flightService)\r\n        {\r\n            _flightService = flightService;\r\n        }\r\n    }" },
                                       new Paragraph {
                                         Body = "The <b>[Route(\"api/[controller]\")]</b> attribute specifies the routing pattern for the controller. The <b>[controller]</b> placeholder is replaced with the name of the controller, minus the \"Controller\" suffix. So, for FlightController, the route becomes <b>api/flight</b>. We'll expand on the subject of routing later in this lesson."
                                     },
                                        new Paragraph {
                                         Body = "<b>ControllerBase</b> serves as a base class from which your API controllers can derive. It provides a range of functionalities and helper methods that make it easier to handle HTTP requests and responses."
                                     },
                                        new Paragraph {
                                         Body = "Similarly to FlightService, where we inject the DBContext, here we're injecting the FlightService through Dependency Injection <b>via the constructor</b>."
                                     },
                                }
                            },
                            new Block
                            {
                                Title = "Routing",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Routing in ASP.NET Core is a powerful mechanism for <b>mapping HTTP requests</b> to the corresponding controller actions. It defines how URL paths are matched to actions in your controllers. There are multiple ways to configure routing, each suitable for different scenarios. Below is a quick overview of the routing system in ASP.NET Core:"
                                    },
                                     new Paragraph {
                                       Body = "<b>Attribute routing</b> uses attributes to define routes directly on controller actions. This approach offers fine-grained control over the routes and is highly readable and maintainable. This is the type we're using in this tutorial."
                                    },
                                      new Paragraph {
                                       Body = "<b>Convention-Based Routing</b> is configured in the Program.cs file, typically using the <b>UseEndpoints</b> method. This method allows you to define a global routing scheme that applies to all controllers"
                                    },
                                       new Paragraph {
                                       Body = "<b>Attribute routing and convention-based routing can be combined</b> within the same application. This allows you to use convention-based routing for general routes and attribute routing for more specific cases."
                                    },
                                        new Paragraph {
                                       Body = "<b>Endpoint Routing</b>, introduced in ASP.NET Core 3.0, is a unified routing system that allows you to define routes using middleware. It provides better performance and more flexibility."
                                    },
                                         new Paragraph {
                                       Body = "<b>Route parameters</b> allow you to capture values from the URL and pass them to controller actions. Example: In the route <b>api/products/{id}</b>, {id} is a route parameter that captures the product ID from the URL."
                                    },
                                          new Paragraph {
                                       Body = "<b>Route constraints</b> restrict how URL parameters can be matched. Constraints are specified in the route template. Example: In the route <b>api/products/{id:int}</b>, :int is a route constraint that specifies the id parameter must be an integer."
                                    },
                                           new Paragraph {
                                       Body = "<b>Custom route handlers</b> can be created for advanced routing scenarios where the built-in routing mechanisms are not sufficient. An example would entail the creation of a class that implements the <b>IRouter</b> interface. This interface defines methods for routing HTTP requests. Custom handlers are out of the scope of this course."
                                    },

                                    new Paragraph {
                                       Body = "Don't worry about memorizing the above. It's just important to keep in mind that although we'll be using attribute routing, you might come across these other approaches in tutorials or when studying other ASP.NET Core Web APIs."
                                    },
                                },
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500059,
                        CourseDisplayId = 10,
                        Title = "Endpoints",
                        Slug = "web-api-endpoints",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                     new Paragraph {
                                         Body = "Endpoints are <b>specific paths in an API</b> that allow clients to interact with the server. Each endpoint is associated with a specific HTTP method (e.g., GET, POST, PUT, DELETE) and a URL path. In the context of a web API, <b>endpoints are the points of interaction where clients can make requests to the server</b> to perform various operations such as retrieving data, creating new entries, updating existing entries, or deleting entries. In FlightsController.cs, after the constructor, add these endpoints:"
                                     },
                                      new Paragraph {
                                          IsCode = true,
                                          Body = " [HttpGet]\r\n        public ActionResult&lt;List&lt;Flight&gt&gt GetAllFlights()\r\n        {\r\n            return Ok(_flightService.GetAllFlights());\r\n        }\r\n\r\n        [HttpGet(\"{id}\")]\r\n        public ActionResult&lt;Flight&gt GetFlightById(int id)\r\n        {\r\n            return Ok(_flightService.GetFlightById(id));\r\n        }\r\n\r\n        [HttpPost]\r\n        public ActionResult&lt;Flight&gt CreateFlight(Flight flight) \r\n        {\r\n            return Ok(_flightService.CreateFlight(flight));\r\n        }\r\n\r\n        [HttpPut(\"{id}\")]\r\n        public ActionResult&lt;Flight&gt UpdateFlight(int id, Flight updatedFlight) \r\n        {\r\n             return Ok(_flightService.UpdateFlight(id, updatedFlight));    \r\n        }\r\n\r\n        [HttpDelete(\"{id}\")]\r\n        public ActionResult&lt;string&gt DeleteFlight (int id) \r\n        {\r\n             return Ok(_flightService.DeleteFlight(id));\r\n        }" },
                                        new Paragraph {
                                         Body = "<b>GetAllFlights:</b> <span style='color:blue'>URL Path: /api/flights</span> . This endpoint retrieves a list of all flights. It uses the HttpGet attribute, meaning it handles GET requests. Returns an <b>HTTP 200 OK</b> response with a list of Flight objects."
                                     },
                                         new Paragraph {
                                         Body = "<b>DeleteFlight</b>: <span style='color:blue'>URL Path: /api/flights/{id}</span>. Deletes a specific flight by its ID. Handles DELETE requests with an ID parameter. The method returns an HTTP 200 OK response with a message indicating the deletion status."
                                     },
                                          new Paragraph {
                                         Body = "<b>GetFlightById</b>: <span style='color:blue'>URL Path: /api/flights/{id}</span>. Retrieves a specific flight by its ID. Handles GET requests with an ID parameter. The method returns an <b>HTTP 200 OK</b> response with the Flight object corresponding to the given ID."
                                     },
                                           new Paragraph {
                                         Body = "<b>CreateFlight</b>: <span style='color:blue'>URL Path: /api/flights</span> Creates a new flight. Handles POST requests. The method takes a Flight object as input and returns an <b>HTTP 200 OK</b> response with the created Flight object."
                                     },
                                            new Paragraph {
                                         Body = "<b>UpdateFlight</b>: <span style='color:blue'>URL Path: /api/flights/{id}</span>. Updates an existing flight by its ID. Handles PUT requests with an ID parameter. The method takes an ID and an updated Flight object as input, and returns an <b>HTTP 200 OK</b> response with the updated Flight object."
                                     }
                                }
                            },
                            new Block
                            {
                                Title = "ActionResult",
                                Paragraphs = new List<Paragraph>
                                {
                                       new Paragraph {
                                         Body = "In ASP.NET Core, the ActionResult type is used in controller actions to <b>represent various HTTP responses</b> returned to clients. Controllers in ASP.NET Core act as intermediaries, handling client requests and determining the appropriate responses. When using ActionResult, developers can return a range of HTTP status codes and payloads, helping clients understand the request's success or failure."
                                     },
                                        new Paragraph {
                                         Body = "The <b>ActionResult&lt;T&gt</b> type allows developers to specify a more descriptive response by using a generic type, like ActionResult&lt;Flight&gt. In the example, ActionResult&lt;List&lt;Flight&gt&gt and ActionResult&lt;Flight&gt indicate that the expected result is a List&lt;Flight&gt or a single Flight object, respectively, wrapped in an <b>HTTP response</b>. When a controller action returns Ok(), it sends a <b>200 OK status code</b> along with the specified object. This approach is beneficial for API design because it not only informs clients of the successful response but also provides the requested data in a straightforward, expected structure."
                                     }
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "You can find the code for the current state of this project <a href='https://github.com/TheCSharpAcademy/TCSA.Course.WebAPI.FlightData/tree/5.Flight-Controller' target='_blank'>in this link</a>." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500060,
                        CourseDisplayId = 11,
                        Title = "Response Codes",
                        Slug = "web-api-response-codes",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                     new Paragraph {
                                         Body = "Response codes in web APIs, often referred to as HTTP status codes, are <b>three-digit numbers returned by servers to indicate the result</b> of a client's request. These codes are standardized by the Internet Engineering Task Force (IETF) and are an integral part of the HTTP protocol. They help the client understand the outcome of the request and act accordingly. Here’s an overview of the main categories and some common codes within each:"
                                     }
                                }
                            },
                            new Block
                            {
                                Title = "Informational",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                         Body = "These codes indicate that the server has received the request and is continuing the process:"
                                     },
                                       new Paragraph {
                                         Body = "<b>100 Continue:</b> The server has received the request headers, and the client should proceed to send the request body."
                                     },
                                        new Paragraph {
                                         Body = "<b>101 Switching Protocols:</b> The server is switching protocols as requested by the client."
                                     }
                                }
                            },
                            new Block
                            {
                                Title = "Success",
                                Paragraphs = new List<Paragraph>
                                {
                                       new Paragraph {
                                         Body = "These codes signify that the client's request was successfully received, understood, and accepted:"
                                     },
                                        new Paragraph {
                                         Body = "<b>200 OK</b>: The request was successful, and the server returned the requested resource."
                                     },
                                        new Paragraph {
                                         Body = "<b>201 Created</b>: The request was successful, and a new resource was created as a result."
                                     },
                                        new Paragraph {
                                         Body = "<b>204 No Content</b>: The request was successful, but there is no content to send in the response."
                                     }
                                }
                            },
                            new Block
                            {
                                Title = "Redirection",
                                Paragraphs = new List<Paragraph>
                                {
                                       new Paragraph {
                                         Body = "These codes indicate that further action is needed to complete the request:"
                                     },
                                        new Paragraph {
                                         Body = "<b>301 Moved Permanently</b>: The requested resource has been permanently moved to a new URL."
                                     },
                                        new Paragraph {
                                         Body = "<b>302 Found</b>: The requested resource resides temporarily under a different URL."
                                     },
                                        new Paragraph {
                                         Body = "<b>304 Not Modified</b>: The resource has not been modified since the last request, so the client can use a cached version."
                                     }
                                }
                            },
                            new Block
                            {
                                Title = "Client Errors",
                                Paragraphs = new List<Paragraph>
                                {
                                       new Paragraph {
                                         Body = "These codes indicate that there was an error with the request from the client’s side:"
                                     },
                                        new Paragraph {
                                         Body = "<b>400 Bad Request</b>: The server could not understand the request due to invalid syntax."
                                     },
                                         new Paragraph {
                                         Body = "<b>401 Not Authorized</b>: The client must authenticate itself to get the requested response."
                                     },
                                        new Paragraph {
                                         Body = "<b>403 Forbidden</b>: The client does not have access rights to the content."
                                     },
                                        new Paragraph {
                                         Body = "<b>404 Not Found</b>: The server cannot find the requested resource."
                                     },
                                        new Paragraph {
                                         Body = "<b>405 Method Not Allowed</b>: The request method is known by the server but has been disabled and cannot be used."
                                     }
                                }
                            },
                            new Block
                            {
                                Title = "Server Errors",
                                Paragraphs = new List<Paragraph>
                                {
                                       new Paragraph {
                                         Body = "These codes indicate that the server failed to fulfill a valid request:"
                                     },
                                        new Paragraph {
                                         Body = "<b>500 Internal Server Error</b>: The server encountered an unexpected condition that prevented it from fulfilling the request."
                                     },
                                        new Paragraph {
                                         Body = "<b>501 Not Implemented</b>: The server does not support the functionality required to fulfill the request."
                                     },
                                        new Paragraph {
                                         Body = "<b>502 Bad Gateway</b>: The server, while acting as a gateway or proxy, received an invalid response from the upstream server."
                                     },
                                        new Paragraph {
                                         Body = "<b>503 Service Unavailable</b>: The server is not ready to handle the request, often due to being overloaded or down for maintenance."
                                     },
                                        new Paragraph {
                                         Body = "Here's a list of <a href='https://developer.mozilla.org/en-US/docs/Web/HTTP/Status' target='_blank'>all HTTP response status codes</a>"
                                     },

                                }
                            },
                            new Block
                            {
                                Title = "Using 404 Not Found",
                                Paragraphs = new List<Paragraph>
                                {
                                       new Paragraph {
                                         Body = "Let's apply our knowledge of response codes with a small modification in our controller. Modify the following endpoints to return a Not Found response when the requested flight isn't found:"
                                     },
                                        new Paragraph {
                                         IsCode = true,
                                         Body = " [HttpGet(\"{id}\")]\r\n    public ActionResult&lt;Flight&gt GetFlightById(int id)\r\n    {\r\n        var result = _flightService.GetFlightById(id);\r\n\r\n        if (result == null)\r\n        {\r\n            return NotFound();\r\n        }\r\n\r\n        return Ok(result);\r\n    }\r\n\r\n\r\n    [HttpPut]\r\n    public ActionResult&lt;Flight&gt UpdateFlight(Flight flight)\r\n    {\r\n        var result = _flightService.GetFlightById(flight.Id);\r\n\r\n        if (result == null)\r\n        {\r\n            return NotFound();\r\n        }\r\n\r\n        return Ok(result);\r\n    }\r\n\r\n    [HttpDelete(\"{id}\")]\r\n    public ActionResult&lt;Flight&gt DeleteFlight(int id)\r\n    {\r\n        var result = _flightService.GetFlightById(id);\r\n\r\n        if (result == null)\r\n        {\r\n            return NotFound();\r\n        }\r\n\r\n        return Ok(result);\r\n    }"
                                     }
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "You can find the code for the current state of this project <a href='https://github.com/TheCSharpAcademy/TCSA.Course.WebAPI.FlightData/tree/6.Response-Codes' target='_blank'>in this link</a>." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500061,
                        CourseDisplayId = 12,
                        Title = "Testing With Swagger",
                        Slug = "web-api-test-swaggeron",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                     new Paragraph {
                                         Body = "It's time to finally test our Flights API! For this we'll use two testing tools: Swagger and Postman."
                                     }
                                }
                            },
                            new Block
                            {
                                Title = "What is Swagger?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                         Body = "Swagger is an open-source tool used in ASP.NET Core to automatically generate interactive documentation for APIs. By integrating Swagger into an ASP.NET Core project, developers can easily visualize, explore, and test their API endpoints without needing to write extensive documentation manually. Here's how it works:"
                                     },
                                       new Paragraph {
                                         Body = "<b>Automatic API Documentation:</b> Swagger reads the metadata from your ASP.NET Core API and creates documentation based on your controllers, routes, and models. This documentation includes descriptions of endpoints, HTTP methods, parameters, and response types."
                                     },
                                        new Paragraph {
                                         Body = "<b>Interactive UI:</b> Swagger UI provides a web interface where you can view and interact with API endpoints. You can execute HTTP requests (like GET, POST, etc.) directly from the browser, test responses, and see results in real-time."
                                     },
                                         new Paragraph {
                                         Body = "<b>Supports OpenAPI:</b> Swagger implements the <b>OpenAPI Specification (OAS)</b>, making it a standard for describing REST APIs. This makes it compatible with various tools and can be used to generate client SDKs or API documentation in different formats."
                                     }
                                }
                            },
                            new Block
                            {
                                Title = "Testing With Swagger",
                                Paragraphs = new List<Paragraph>
                                {
                                       new Paragraph {
                                         Body = "Once we run the app, your browser should open with this interface:"
                                     },
                                        new Paragraph {
                                            IsPicture = true,
                                         PictureUrl = "c3-ch12-webapis-swagger-interface.png"
                                     },
                                        new Paragraph {
                                         Body = "Let's start testing the creation of a flight. Expand the Post endpoint, click on <b>Try it Out</b> and fill the inputs for each property of the flight. <b>You don't need to provide the Id</b>, as it's populated by the database itself. <b>Click on Execute</b>. If the request is correct you'll see this:"
                                     },
                                        new Paragraph {
                                            IsPicture = true,
                                         PictureUrl = "c3-ch12-webapis-swagger-create.png"
                                     },
                                        new Paragraph {
                                         Body = "Repeat the process and create a second flight, modifying the data as you wish. Next let's test the GetAll method. Click on Try it out and Execute. You should see something like this:"
                                     },
                                         new Paragraph {
                                            IsPicture = true,
                                         PictureUrl = "c3-ch12-webapis-swagger-getall.png"
                                     },
                                          new Paragraph {
                                         Body = "Proceed to test GetById, Delete and Put. For any of these methods, if you use an id that doesn't exist in the database you'll get a 404 response:"
                                     },
                                         new Paragraph {
                                            IsPicture = true,
                                         PictureUrl = "c3-ch12-webapis-swagger-notfound.png"
                                     },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500062,
                        CourseDisplayId = 13,
                        Title = "Testing With Postman",
                        Slug = "web-api-test-postman",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                     new Paragraph {
                                         Body = "Although ASP.NET Core Web APIs can be easily configured to work with Swagger, The C# Academy's recommendeds Postman, a popular API development and testing tool that simplifies the process of working with web APIs. Here are some key points about Postman and why it's widely used:"
                                     },
                                    new Paragraph {
                                         Body = "✅ <b>User-Friendly Interface</b>: Postman offers an intuitive and easy-to-use graphical interface, allowing developers to create and manage API requests without needing to write code for each request."
                                     },
                                    new Paragraph {
                                         Body = "✅ <b>Comprehensive Features</b>: It provides a robust set of features including request building, testing, documentation, and monitoring of APIs."
                                     },
                                    new Paragraph {
                                         Body = "✅ <b>Cross-Platform</b>: Postman is available on Windows, macOS, and Linux, making it accessible to a wide range of developers."
                                     },
                                    new Paragraph {
                                         Body = "✅ <b>Collaboration Tools</b>: Postman allows team collaboration through shared workspaces, collections, and environment configurations, making it easier to work on APIs in a collaborative setting."
                                     }
                                }
                            },
                            new Block
                            {
                                Title = "Postman's Main Features",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                         Body = "➡️ <b>Request Building</b>: You can easily create and configure HTTP requests (GET, POST, PUT, DELETE, etc.) with headers, parameters, and body content."
                                     },
                                       new Paragraph {
                                         Body = "➡️ <b>Environment Management</b>: Postman allows you to create different environments (e.g., development, staging, production) and switch between them seamlessly. This helps in managing different configurations for different stages of API development.\r\n"
                                     },
                                        new Paragraph {
                                         Body = "➡️ <b>Automated Testing</b>: Postman supports automated testing through its built-in scripting environment. You can write tests using JavaScript to validate the responses of your API requests."
                                     },
                                         new Paragraph {
                                         Body = "➡️ <b>Mock Servers</b>: Postman can create mock servers to simulate API responses, which is useful for testing and developing against APIs that are still in development or not always available.\r\n"
                                     },
                                         new Paragraph {
                                         Body = "➡️ <b>Documentation</b>: Postman can generate API documentation automatically from your collections, which can be shared with your team or clients."
                                     },
                                         new Paragraph {
                                         Body = "➡️ <b>Monitoring</b>: You can set up monitors to run your collections at scheduled intervals to check the health and performance of your APIs."
                                     }
                                }
                            },
                            new Block
                            {
                                Title = "Using Postman",
                                Paragraphs = new List<Paragraph>
                                {
                                       new Paragraph {
                                         Body = "Navigate to <a href='https://www.postman.com/' target='_blank'>Postman's website</a> download the app and create an account. You can use it without registering but an account allows you to save your collections of requests for future use, one of the main advantages of using Postman. "
                                     },
                                        new Paragraph {
                                         Body = "Once logged in, click on <b>Workspaces > My Workspaces</b>. You'll see the window you can send requests from. Let's start with GetAll. Copy and paste your endpoint's URL and <b>click on Send</b>, as per the picture below. Keep in mind your localhost might be using a different port: "
                                     },
                                        new Paragraph {
                                            IsPicture = true,
                                         PictureUrl = "c3-ch13-webapis-postman-interface.png"
                                     },
                                        new Paragraph {
                                         Body = "To create a post request we will need to send a <b>json object as a payload</b>. For this change the type of request to Post (at the left of the URL), click Body and check the \"raw\" option as per the picture below. To speed things up you can use the provided json: \r\n"
                                     },
                                         new Paragraph {
                                            IsCode = true,
                                         Body = "{\r\n    \"FlightNumber\": 650,\r\n    \"AirlineName\": \"C# Airlines\",\r\n    \"DepartureAirportCode\": \"LAX\",\r\n    \"ArrivalAirportCode\": \"JFK\",\r\n    \"DepartureDateTime\": \"2024-12-04T07:00:00\",\r\n    \"ArrivalDateTime\":\"2024-12-04T11:00:00\",\r\n    \"PassengerCapacity\": 150\r\n}"
                                     },
                                         new Paragraph {
                                            IsPicture = true,
                                         PictureUrl = "c3-ch13-webapis-postman-post.png"
                                     },
                                          new Paragraph {
                                         Body = "To delete, update or get a record you'll need to pass the id in the query as per picture:"
                                     },
                                         new Paragraph {
                                            IsPicture = true,
                                         PictureUrl = "c3-ch13-webapis-postman-parameter.png"
                                     },
                                }
                            },
                            new Block
                            {
                                Title = "Saving a Collection",
                                Paragraphs = new List<Paragraph>
                                {
                                       new Paragraph {
                                         Body = "To Create a new Collection and Save your requests for future use, click on the plus sign on the top left, choose Blank Collection. Click on the three dots near the \"New Collection\" created and rename it to Flights API. You can now click on Save on the right top and choose to save your request in the collection you desire."
                                     },
                                      new Paragraph {
                                         IsPicture = true,
                                         PictureUrl = "c3-ch13-webapis-swagger-collections.png"
                                     },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500063,
                        CourseDisplayId = 14,
                        Title = "Conclusion",
                        Slug = "oop-conclusion",
                        Description = "Let's create the console app, install a package and write some code!",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Congratulations! You've completed the Intro to ASP.NET Core Web APIs course! You should know be familiar with one of the most important parts of ASP.NET Core. Understanding Web APIs means knowing how applications reach each other via HTTP requests, which is at the core of how the internet works." },
                                }
                            },
                            new Block
                            {
                                Title = "What To Do Now",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We recommend you write down a reflection about what you've just learned. What did you think of the course? What are sub-topics you still feel you don't understand well? What feels more clear to you now?" },
                                    new Paragraph {
                                       Body = "If you're following our roadmap, there are several projects that have a Web Api as a requirement, starting with the Shifts Logger. Several projects in the Angular and React areas involve building APIs. You can also submit a Freestyle Project, if you have an idea that's not covered in our curriculum. " },
                                    new Paragraph {
                                       Body = "You can also revisit this course at any time. Each time you repeat a course, you'll find that you'll learn something new or see the same topic from a new perspective, no matter how many times you do it." },
                                    new Paragraph { Body = "Keep in mind that this is an intro course covering the basics of Web APIs. We're working on an intermediate and an advanced course, covering topics for students that are already very comfortable the material in this course. Stay tuned! And once again! Congratulations!" }
                                }
                            },
                            new Block
                            {
                                Title = "Video Course",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We also have a paid video version of this tutorial. The video version already contains a part 2, with the intermediate content.:<br><br>\r\n<b>Option 1</b>: Purchase the course <a href='https://thecsharpschool.getlearnworlds.com/course/aspnet-core-web-apis' target='_blank'>individually for $4.99</a>.<br>\r\n<b>Option 2</b>: Subscribe to the <b>VIP Membership</b> and have access to <a href='https://thecsharpschool.getlearnworlds.com/payment?product_id=the-c-academy-membership&type=subscription' target='_blank'>all our courses for $4.99/month</a><br>\r\n<b>Option 3</b>: Subscribe to the <b>VIP Mentorship</b> for <a href='https://thecsharpschool.getlearnworlds.com/payment?product_id=net-accelerator-mentorship&type=subscription' target='_blank'>all courses and 1-on-1 mentorship for 39.99/month</a>" }
                                }
                            },
                        }
                    }
                }
            },
            new Course
            {
                Id = 4,
                Title = "Introduction to SQL",
                Description = "Master speech capabilities in Azure AI for dynamic, voice-driven applications!",
                Articles = new List<Article>
                {
                    new Article
                    {
                        Id = 500070,
                        CourseDisplayId = 1,
                        Title = "Introduction",
                        Slug = "intro-to-sql-intro",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Welcome to the fascinating world of SQL! We're excited to have you on this journey, where you'll build a solid foundation in the <b>world's most widely used database language</b>." },
                                    new Paragraph {
                                       Body = "Learning SQL is essential for anyone working with data, whether in software development, business analysis, or data science. It enables you to query and analyze information, which is critical for making informed decisions. Additionally, <b>SQL is universally recognized</b>, meaning the skills you gain will transfer across various database systems and industries. Whether you're building applications, managing databases, or diving into data analytics, SQL serves as a foundational tool that opens up countless opportunities." },
                                     new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "sql-image.jpeg"}
                                }
                            },
                            new Block
                            {
                                Title = "Pre-requisites",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "This course is designed for <b>absolute beginners</b>, so no prior experience with SQL or databases is required. You don’t need to have any SQL knowledge to get started. All concepts will be introduced step-by-step, with clear explanations and practical examples to help you understand and apply what you learn. Whether you’re completely new to SQL or looking to expand your skills into database management, this course will guide you from the very basics to confidently working with SQL." },
                                    new Paragraph {
                                       Body = "This course is part of The C# Academy's curriculum. While we won’t be using C# in this project, learning SQL in isolation will give you the essential skills needed to interact with databases effectively when you use it with C# in future projects. By focusing on SQL in this course, you’ll gain a clear understanding of how databases work, preparing you to integrate these concepts with C# later in the curriculum. <b>We'll have a separate course on SQL for C# developers.</b>" }
                                }
                            },
                            new Block
                            {
                                Title = "What to Expect",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "This is a beginner-friendly course, so advanced concepts like database management and administration will not be included. Instead, we’ll focus on <b>foundational SQL skills</b> and learn in the context of an e-commerce business case scenario. This practical approach will help you understand how SQL can be applied to real-world problems while keeping the learning process straightforward and accessible." }
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        BackgroundColor="#1C236D",
                                        FontColor="#FFF",
                                        Body = "Did you know that SQL was initially called \"SEQUEL\" (Structured English Query Language)? It was later renamed SQL due to a trademark conflict, but the pronunciation \"sequel\" is still widely used today!" }
                                }
                            },
                        }
                    },
                    new Article
                    {
                        Id = 500071,
                        CourseDisplayId = 2,
                        Title = "Working With Sqlite",
                        Slug = "intro-to-sql-sqlite",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "SqLite is a lightweight, self-contained, serverless database engine that <b>stores data in a single file</b>. Unlike traditional database systems like MySQL or SQL Server, SQLite doesn’t require a separate server to manage its databases, making it incredibly portable and easy to use. Despite its simplicity, it is a powerful and reliable tool that is widely used in mobile applications, small-scale projects, and embedded systems. Its ability to handle basic SQL operations while remaining fast and efficient makes it ideal for learning and experimentation."},
                                    new Paragraph { 
                                        IsPicture = true,
                                        PictureUrl = "c4-ch2-sql-sqlite.png"}
                                },
                            },
                            new Block
                            {
                                Title = "Why Sqlite?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "SQLite is perfect for beginners because of its simplicity and accessibility. There’s no need for complicated installations or configurations; you can start working with a database almost immediately. Its self-contained nature ensures you can focus on learning SQL concepts without being distracted by the complexities of setting up a database server. Additionally, <b>SQLite adheres to standard SQL syntax</b>, which means the skills you develop here will translate directly to other database systems in the future." }
                                }
                            },
                            new Block
                            {
                                Title = "Setting Up",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Setting up Sqlite is very easy. <a href='https://sqlitebrowser.org/' target='_blank'>All you need to do is download DB Browser</a>, a popular cross-platform graphical interface tool that provides a user-friendly way to create and manage your databases. When installing, <b>choose the option to create shortcuts</b> to save you some time. You'll be using the application frequently."
                                    },
                                     new Paragraph {
                                       Body = "Once you click on the shorcut, if the installation was successful, you'll see the following interface:" },
                                      new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "c4-ch2-sql-sqlite2.png"}
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        BackgroundColor="#1C236D",
                                        FontColor="#FFF",
                                        Body = "SQLite is so lightweight and self-contained that it has been used in everything from web browsers to spacecraft. It doesn’t require a separate server to operate, making it incredibly versatile!" }
                                }
                            },
                        }
                    },
                    new Article
                    {
                        Id = 500072,
                        CourseDisplayId = 3,
                        Title = "SQL Data Types",
                        Slug = "intro-to-sql-data-types",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Data types <b>define the kind of data that can be stored in a column</b>, such as text, numbers, or dates. They play a critical role in ensuring data consistency and optimizing database performance. While SQL as a language supports a wide variety of data types, each database system implements them differently. SQLite uses a more flexible and <b>simplified approach</b> to data types, while SQL Server adheres to strict typing with an extensive set of predefined types.\r\n" }
                                }
                            },
                            new Block
                            {
                                Title = "Data Types in SQLite",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "SQLite employs dynamic typing, meaning it doesn’t strictly enforce column data types. Instead, it uses type affinities, which are broad categories for data: <b>TEXT, INTEGER, REAL, BLOB, and NULL</b>. For example, a column defined as TEXT can store numbers, text, or even date strings, though SQLite will attempt to interpret and store values in the most appropriate format. This flexibility can simplify development but requires careful handling to avoid inconsistent data."}
                                }
                            },
                            new Block
                            {
                                Title = "Data Types in SQL Server",
                                Paragraphs = new List<Paragraph>
                                {
                                      new Paragraph { Body = "The widely used SQL Server, in contrast, enforces strict data typing. Columns are explicitly defined with specific types like <b>INT, VARCHAR, DECIMAL, or DATETIME</b>, and only data matching the defined type can be stored. This ensures data integrity and allows for advanced optimizations, especially in large-scale applications. SQL Server also offers a much larger variety of types, including specialized ones like <b>UNIQUEIDENTIFIER</b> for globally unique identifiers or XML for storing structured data." }
                                }
                            },
                            new Block
                            {
                                Title = "How They Differ",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "The key difference between SQLite and SQL Server lies in their approach to typing. SQLite’s dynamic typing makes it easy to work with data without worrying about strict rules, which is helpful for learning and prototyping. However, <b>it sacrifices some data integrity and precision</b>. SQL Server’s strict typing demands more upfront planning when designing a database, but it ensures that the data remains consistent and predictable, which is crucial for complex systems." },
                                    new Paragraph {
                                       Body = "As we move forward, understanding these differences will help you choose the right database for your projects and prepare you to adapt your SQL knowledge to different systems. For now, we will focus on SQLite's simpler type system, keeping things accessible and beginner-friendly." },
                                     new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "c4-ch3-sql-sqlite-vs-sqlserver.png"}

                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "BLOBs for Everything: The BLOB type in SQLite is the ultimate wildcard — it can store any kind of binary data, including images, files, or serialized objects." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500073,
                        CourseDisplayId = 4,
                        Title = "Table Creation",
                        Slug = "intro-to-sql-data-types-table-creation",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "It's time to start writing SQL! In this chapter, we will focus on creating a table for managing products in an e-commerce store. This is one of the core aspects of building a database, as tables store the data for the system. We will explore how to define the table structure, choose appropriate data types for each column, and understand the relationships between the fields." },
                                     new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "c4-ch4-sql-ecommerce.jpg"}
                                }
                            },
                            new Block
                            {
                                Title = "Understanding Table Creation",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "A table in SQL consists of <b>rows and columns</b>, where each column holds a specific type of data. To create a table, we use the <b>CREATE TABLE</b> statement, followed by the table name and column definitions. Each column is defined with a name and a corresponding data type. You can also set constraints on the columns to ensure data integrity."},
                                    new Paragraph { Body = "Let’s start by creating a simple Products table for an e-commerce store. This table will store basic information about each product available for sale."},
                                    new Paragraph { 
                                        IsCode = true,
                                        Body = "CREATE TABLE Products (\r\n    ProductID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    ProductName TEXT NOT NULL,\r\n    Description TEXT,\r\n    Price REAL NOT NULL,\r\n    StockQuantity INTEGER NOT NULL,\r\n    DateAdded DATE\r\n);"},
                                    new Paragraph { Body = "Now, let’s break down each part of this table creation in detail:"},
                                    new Paragraph { Body = "<b>Line 1: CREATE TABLE</b>: This SQL command is used to define a new table in the database. Products: This is the name of the table being created. You can give the table any name you want. The name should be descriptive of the data it will contain. In this case, the table will hold product-related information. "},
                                    new Paragraph { Body = "<b>Line 2: ProductID INTEGER PRIMARY KEY AUTOINCREMENT</b>. ProductID: This is the name of the column. It serves as a <b>unique identifier</b> for each row in the table. INTEGER: The data type of the column. It specifies that ProductID will store whole numbers. PRIMARY KEY: This keyword designates ProductID as the primary key of the table. A primary key uniquely identifies each row in the table and ensures that no two rows have the same value for this column. AUTOINCREMENT: This ensures that the value of ProductID is automatically incremented by the database each time a new row is added. It starts at 1 and increases sequentially."},
                                    new Paragraph { Body = "<b>Line 3: ProductName TEXT NOT NULL</b>. ProductName: The name of the column, which will store the name of the product. TEXT: The data type for the column. It specifies that ProductName will store string values (e.g., product names). NOT NULL: This constraint ensures that the ProductName column cannot contain NULL values. A value must be provided for every row."},
                                    new Paragraph { Body = "<b>Line 4: Description TEXT</b>. Description: The name of the column, which will store additional details about the product. It also has TEXT as its data type."},
                                    new Paragraph { Body = "<b>Line 5: Price REAL NOT NULL</b>. Price: The name of the column, which will store the product's price. REAL: The data type for the column. It is used to store floating-point numbers (decimal values). A valid price must always be provided."},
                                    new Paragraph { Body = "<b>Line 6: StockQuantity INTEGER NOT NULL</b>. StockQuantity: The name of the column, which will store the number of products available in stock. The data type is integer and cannot contain null values."},
                                     new Paragraph { Body = "<b>Line 7: DateAdded DATE</b>. DateAdded: The name of the column, which will store the date when the product was added to the database. The DATE type It is used to store date values (in the format YYYY-MM-DD in most SQL databases).It doesn't have the NOT NULL , meaning it’s optional."}
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "You have probably noticed that some words in our SQL statement are in upper-case. By convention, upper-case is used for SQL keywords, while lower case is used for custom words, such as names of properties and tables. It's also advisable to declare each property of a table in a new line. These approaches are optional, but help improving readability." }
                                }
                            },
                            new Block
                            {
                                Title = "Constraints and Data Integrity",
                                Paragraphs = new List<Paragraph>
                                {
                                      new Paragraph { Body = "In SQL, <b>constraints</b> are rules applied to the columns in a table to ensure that the data entered into the database adheres to certain conditions. These rules are crucial for maintaining <b>data integrity</b>, accuracy, and reliability within the database. Constraints help enforce the correctness of the data by ensuring that it follows predefined criteria before being saved." },
                                      new Paragraph { Body = "As shown above, we’ve applied a few constraints to the table: <b>PRIMARY KEY</b> on ProductID: Ensures uniqueness and helps optimize queries that retrieve a product by its ID. <b>NOT NULL</b> on columns like ProductName, Price, and StockQuantity: Ensures that essential data is always provided for every product. No <b>NOT NULL</b> on Description and DateAdded: This allows for flexibility, enabling optional information while still keeping the table structured.\r\n" },
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "Columns like Description and DateAdded are optional because they allow NULL values. Keep in mind that a NULL value doesn’t mean \"zero\" or \"empty\" — it means \"unknown\" or \"not applicable,\" making databases a bit philosophical when it comes to missing information!" }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500074,
                        CourseDisplayId = 5,
                        Title = "Practice Creating a Table",
                        Slug = "intro-to-sql-practice-create",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In DB Browser Menu, click on the first item: <b>New Database</b>. Choose a location in your file system, a name and save. We're naming our file ecommerce, but you can choose any name you prefer. Navigate to the folder where you created the table and if everything worked correctly, you'll see your database file:" },
                                    new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "c4-ch5-sql-db-file.png"},
                                }
                            },
                            new Block
                            {
                                Title = "Applying Your First Script",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Just below the Top Menu, you'll see a few tabs. In the <b>Execute SQL</b> tab, paste the script to create the table and click on the <b>Play button</b>, which executes the script:"},
                                    new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "c4-ch5-sql-sqlite-practice-create.png"}
                                }
                            },
                            new Block
                            {
                                Title = "Examine the Table",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Now choose the <b>Database Structure</b> tab. If everything worked correctly you'll see the table's properties:"},
                                    new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "c4-ch5-sql-examine-table.png"}
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "SQLite tables can theoretically store up to 2^64 - 1 rows, which is about 18 quintillion rows. However, the practical limit is often much lower, depending on: 1. Database file size: The total database size cannot exceed 140 terabytes (TB) for a single SQLite database file. 2.Memory and disk space: While SQLite supports very large numbers of rows, the actual limit will be constrained by available system memory and storage.\r\nSQLite is designed to be lightweight, so while it can handle a massive number of rows, it is best used for smaller to medium-sized applications rather than as a large-scale enterprise database solution." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500075,
                        CourseDisplayId = 6,
                        Title = "Inserting Data",
                        Slug = "intro-to-sql-insert",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In SQL, the <b>INSERT</b> statement is used to add new rows of data into a table. This is a fundamental operation when working with databases because it allows you to populate tables with data and create records. It can be written in different ways, depending on how much information you want to provide and whether or not you want to include columns that allow NULL values." },
                                    new Paragraph { Body = "Here’s an example of inserting data into our Products table, which includes all columns." },
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "INSERT INTO Products (ProductID, ProductName, Description, Price, StockQuantity, DateAdded)\r\nVALUES (NULL, 'Wireless Headphones', 'Noise-canceling over-ear headphones', 59.99, 100, '2024-11-24');\r\n"},
                                }
                            },
                             new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "In DbBrowser, When executing commands that modify data, such as INSERT, <b>you need to save your changes or they won't persist</b>. You can do that by clicking on <b>File > Write Changes</b> in the left of the top menu." }
                                }
                            },
                            new Block
                            {
                                Title = "Inserting All Values",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "<b>INSERT INTO Products</b>: This part specifies the table where we want to insert the data (Products)"},
                                    new Paragraph { Body = "<b>ProductID, ProductName, Description, Price, StockQuantity, DateAdded</b>: These are the columns that we are inserting values into."},
                                    new Paragraph { Body = "<b>VALUES (NULL, 'Wireless Headphones', 'Noise-canceling over-ear headphones', 59.99, 100, '2024-11-24')</b>: These are the actual values being inserted. They need to be in the same order as the columns declared in the previous part of the query."},
                                    new Paragraph { Body = "<b>We use NULL for the ProductID column</b> because this column is set to auto-increment. The database will automatically assign a unique ID value to it."},
                                    new Paragraph { Body = "This method is ideal when you have data for all columns and don't mind providing values for the columns that allow NULL values."},
                                }
                            },
                            new Block
                            {
                                Title = "Inserting Partial Values",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { 
                                        IsCode = true,
                                        Body = "INSERT INTO Products (ProductName, Price, StockQuantity)\r\nVALUES ('Wireless Headphones', 59.99, 100);\r\n"},
                                    new Paragraph {
                                        Body = "In cases where a column can accept NULL values, <b>you don't need to explicitly include them</b> in your INSERT statement. If you omit a column that allows NULL, the database will automatically insert a NULL value for that column (or the default value, if specified). This approach is useful when you only have data for some of the columns and the others are optional."}
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "INSERT is one of the most universally understood SQL commands across different database systems. Whether you’re using MySQL, PostgreSQL, SQL Server, or Oracle, the syntax is strikingly similar, making it easy to work across platforms." }
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Click on the button below to see a script to insert 100 products into our database. We'll be using this dataset for practice in the next lessons." }
                                }
                            },
                            new Block
                            {
                                IsCourseCodePage = true,
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       IsCode = true,
                                       Body = "INSERT INTO Products (ProductName, Description, Price, StockQuantity, DateAdded) VALUES\r\n('Wireless Headphones', 'Noise-canceling over-ear headphones', 59.99, 100, '2024-01-05'),\r\n('Bluetooth Speaker', 'Compact and portable with powerful sound', 79.99, 50, '2024-02-10'),\r\n('Smart Watch', 'Tracks fitness and daily activities', 199.99, 30, '2024-03-15'),\r\n('Gaming Mouse', 'High precision and customizable buttons', 49.99, 200, '2024-04-01'),\r\n('4K Monitor', 'Ultra HD display with vibrant colors', 299.99, 25, '2024-05-20'),\r\n('Noise-Canceling Earbuds', 'Compact design with superior sound', 89.99, 120, '2024-06-11'),\r\n('Portable Charger', 'High-capacity power bank for on-the-go', 39.99, 300, '2024-07-04'),\r\n('Smartphone', 'Latest model with advanced features', 999.99, 15, '2024-08-18'),\r\n('Tablet', 'Lightweight and powerful for all tasks', 399.99, 20, '2024-09-30'),\r\n('Laptop', 'High-performance laptop for work and play', 1299.99, 10, '2024-10-12'),\r\n('Smart Thermostat', 'Energy-efficient home temperature control', 149.99, 40, '2024-01-22'),\r\n('VR Headset', 'Immersive virtual reality experience', 349.99, 18, '2024-02-18'),\r\n('Electric Scooter', 'Eco-friendly transportation solution', 799.99, 8, '2024-03-12'),\r\n('Action Camera', 'Capture adventures in stunning detail', 249.99, 70, '2024-04-25'),\r\n('Smart Doorbell', 'Secure and convenient home monitoring', 99.99, 50, '2024-05-14'),\r\n('Gaming Console', 'Next-gen gaming at its finest', 499.99, 12, '2024-06-22'),\r\n('Robot Vacuum', 'Effortless cleaning for any home', 299.99, 30, '2024-07-18'),\r\n('Fitness Tracker', 'Track your fitness goals daily', 59.99, 150, '2024-08-10'),\r\n('Wireless Keyboard', 'Ergonomic design and long battery life', 29.99, 200, '2024-09-05'),\r\n('External Hard Drive', 'Portable storage solution', 79.99, 80, '2024-10-27'),\r\n('Photography Drone', 'High-quality drone for photography', 599.99, 10, '2024-01-03'),\r\n('Smart Home Hub', 'Centralized control for smart devices', 129.99, 45, '2024-02-14'),\r\n('Streaming Device', 'Stream your favorite content on TV', 49.99, 90, '2024-03-01'),\r\n('Gaming Chair', 'Ergonomic chair for long gaming sessions', 199.99, 25, '2024-04-11'),\r\n('Graphic Tablet', 'Professional tablet for digital art', 349.99, 12, '2024-05-06'),\r\n('E-Reader', 'Lightweight e-reader with long battery life', 129.99, 60, '2024-06-15'),\r\n('Portable Projector', 'Mini projector for presentations', 249.99, 20, '2024-07-09'),\r\n('Mechanical Keyboard', 'Tactile and durable mechanical keyboard', 79.99, 110, '2024-08-03'),\r\n('Noise Meter', 'Handheld device for measuring noise levels', 39.99, 50, '2024-09-18'),\r\n('Smart Light Bulbs', 'Customizable smart lighting', 59.99, 100, '2024-10-02'),\r\n('Power Drill', 'Cordless power drill with accessories', 99.99, 80, '2024-01-25'),\r\n('Cookware Set', 'Non-stick cookware set for your kitchen', 149.99, 35, '2024-02-05'),\r\n('Espresso Machine', 'Professional-grade coffee maker', 399.99, 10, '2024-03-16'),\r\n('Digital Thermometer', 'Accurate readings for home use', 19.99, 150, '2024-04-30'),\r\n('Stand Mixer', 'Powerful stand mixer for baking', 249.99, 15, '2024-05-20'),\r\n('Gaming Laptop', 'High-performance gaming laptop', 1499.99, 8, '2024-06-11'),\r\n('Smart Air Purifier', 'Improve indoor air quality', 299.99, 25, '2024-07-04'),\r\n('Smart Lock', 'Keyless entry smart lock', 199.99, 50, '2024-08-01'),\r\n('Wireless Router', 'Fast and secure internet connectivity', 79.99, 100, '2024-09-14'),\r\n('Electric Kettle', 'Stylish and efficient kettle', 39.99, 150, '2024-10-18'),\r\n('Bluetooth Headset', 'Lightweight and reliable headset', 49.99, 200, '2024-01-10'),\r\n('Dash Cam', 'High-resolution dash camera', 99.99, 75, '2024-02-25'),\r\n('Smart Pen', 'Digitize your handwritten notes', 129.99, 30, '2024-03-05'),\r\n('Portable Fridge', 'Compact fridge for outdoor use', 299.99, 10, '2024-04-20'),\r\n('Wi-Fi Extender', 'Expand your home Wi-Fi coverage', 49.99, 120, '2024-05-25'),\r\n('Digital Camera', 'Capture high-quality images and videos', 799.99, 15, '2024-06-30'),\r\n('Electric Toothbrush', 'Improve oral health with advanced features', 99.99, 90, '2024-07-15'),\r\n('Waterproof Speaker', 'Durable speaker for outdoor use', 129.99, 50, '2024-08-25'),\r\n('Air Fryer', 'Healthy cooking with less oil', 179.99, 30, '2024-09-06'),\r\n('Smart Scale', 'Track your weight and health metrics', 59.99, 100, '2024-10-20'),\r\n('Handheld Vacuum', 'Compact vacuum for quick cleanups', 89.99, 40, '2024-11-01'),\r\n('Cordless Hair Clippers', 'Professional grooming kit', 49.99, 70, '2024-11-12'),\r\n('Wireless Door Sensor', 'Monitor door activity in real-time', 19.99, 150, '2024-11-23'),\r\n('Smart Ceiling Fan', 'Energy-efficient fan with remote control', 149.99, 20, '2024-12-05'),\r\n('Portable Air Conditioner', 'Cooling solution for small rooms', 299.99, 15, '2024-12-16'),\r\n('Rechargeable Flashlight', 'Bright and durable flashlight', 39.99, 200, '2024-12-27'),\r\n('Digital Alarm Clock', 'Modern design with multiple features', 29.99, 100, '2024-11-08'),\r\n('Electric Blanket', 'Stay warm with adjustable heat levels', 69.99, 50, '2024-11-19'),\r\n('Smart Garden System', 'Automated plant care for home', 199.99, 10, '2024-12-01'),\r\n('Home Security Camera', 'Monitor your property with ease', 99.99, 80, '2024-12-12'),\r\n('Smart Outlet', 'Control appliances from your phone', 24.99, 120, '2024-12-23'),\r\n('Wireless Charger', 'Fast charging for compatible devices', 29.99, 150, '2024-11-02'),\r\n('Electric Griddle', 'Perfect for pancakes and more', 59.99, 40, '2024-11-13'),\r\n('Smart Bike Lock', 'Secure your bike with smartphone access', 99.99, 30, '2024-11-24'),\r\n('Automatic Soap Dispenser', 'Hygienic and touch-free', 29.99, 100, '2024-12-06'),\r\n('Home Theater System', 'Premium surround sound experience', 799.99, 10, '2024-12-17'),\r\n('Robot Lawn Mower', 'Effortless lawn maintenance', 899.99, 8, '2024-12-28'),\r\n('Electric Skillet', 'Multi-functional electric skillet', 49.99, 60, '2024-11-09'),\r\n('Cordless Screwdriver', 'Handy tool for small projects', 29.99, 200, '2024-11-20'),\r\n('Thermal Camera', 'Infrared imaging for professionals', 399.99, 5, '2024-12-02'),\r\n('Electric Wine Opener', 'Open bottles with ease', 39.99, 100, '2024-12-13'),\r\n('Portable Blender', 'Smoothies on the go', 49.99, 80, '2024-12-24'),\r\n('Desktop Air Purifier', 'Keep your workspace fresh', 99.99, 25, '2024-11-03'),\r\n('Solar Power Bank', 'Eco-friendly portable charger', 59.99, 150, '2024-11-14'),\r\n('Digital Picture Frame', 'Display cherished memories', 129.99, 50, '2024-11-25'),\r\n('Instant Camera', 'Capture memories with instant prints', 79.99, 40, '2024-12-07'),\r\n('Portable Heater', 'Stay warm anywhere', 69.99, 30, '2024-12-18'),\r\n('Electric Pressure Cooker', 'Quick and healthy meals', 99.99, 20, '2024-12-29'),\r\n('Cordless Hand Mixer', 'Mix ingredients effortlessly', 39.99, 100, '2024-11-04'),\r\n('Motion Sensor Light', 'Automatic lighting for your home', 19.99, 200, '2024-11-15'),\r\n('Electric Standing Desk', 'Improve posture and productivity', 399.99, 10, '2024-11-26'),\r\n('Smart Coffee Mug', 'Keep beverages at the perfect temperature', 49.99, 80, '2024-12-08'),\r\n('Home Gym Set', 'Compact and versatile workout equipment', 299.99, 15, '2024-12-19'),\r\n('Water Filtration System', 'Clean and safe drinking water', 99.99, 25, '2024-12-30'),\r\n('Electric Bike', 'Eco-friendly transportation', 1199.99, 5, '2024-11-05'),\r\n('Wireless Mouse', 'Reliable and ergonomic', 19.99, 200, '2024-11-16'),\r\n('Adjustable Dumbbells', 'Space-saving fitness solution', 199.99, 20, '2024-11-27'),\r\n('Neck Massager', 'Relieve tension and stress', 59.99, 100, '2024-12-09'),\r\n('Smartphone Gimbal', 'Smooth and steady video recording', 99.99, 50, '2024-12-20'),\r\n('Electric Water Kettle', 'Fast boiling with modern design', 29.99, 150, '2024-12-31'),\r\n('Smart Mirror', 'Interactive mirror with built-in assistant', 299.99, 10, '2024-11-06'),\r\n('Pet Tracker', 'GPS tracking for your furry friends', 49.99, 100, '2024-11-17'),\r\n('Smart Toothbrush', 'Improve dental health with smart features', 99.99, 60, '2024-11-28'),\r\n('Mini Dehumidifier', 'Combat humidity in small spaces', 49.99, 50, '2024-12-10'),\r\n('Electric Hand Warmer', 'Stay warm during cold days', 19.99, 200, '2024-12-21'),\r\n('Smart Water Bottle', 'Track your hydration habits', 39.99, 150, '2024-12-22'),\r\n('Portable Speaker', 'Enjoy music anywhere', 79.99, 70, '2024-12-11'),\r\n('Smart Thermostat', 'Automated home temperature control', 129.99, 40, '2024-12-25'),\r\n('Electric Skateboard', 'Eco-friendly transportation alternative', 499.99, 10, '2024-12-26'),\r\n('Wireless Gaming Headset', 'Immersive sound for gaming', 79.99, 50, '2024-12-27');\r\n\r\n\r\n" }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500076,
                        CourseDisplayId = 7,
                        Title = "Querying Data",
                        Slug = "intro-to-sql-querying",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The <b>SELECT</b> statement is one of the most fundamental and frequently used operations in SQL. It allows you to retrieve data from a table, enabling you to query and view the information stored within your database. It can be customized to fetch specific columns, apply filters, sort results, and even perform complex operations like joins, aggregations, and grouping. Its flexibility makes it a powerful tool for interacting with your data." },
                                }
                            },
                            new Block
                            {
                                Title = "Basic Select statement",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The most basic form of a SELECT query <b>retrieves all columns from a table</b>. In DB Browser, run the following command in the <b>Execute SQL</b> tab. This query will return all 100 records added in the previous chapter."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT * FROM Products"},
                                    new Paragraph { Body = "See the outcome below. Notice there's a pane under the queried data with information about the execution of the query."},
                                    new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "c4-ch7-sql-query-result.png"}
                                }
                            },
                            new Block
                            {
                                Title = "Selecting Specific columns",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Rather than retrieving every column with `*`, <b>you can specify which columns you want</b> to see by naming them. This is useful when you need only specific data from the table."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT ProductName, Price FROM products"},
                                     new Paragraph { Body = "Notice only the requested columns are showing."},
                                    new Paragraph {
                                        IsPicture = true,
                                        PictureUrl = "c4-ch7-sql-query-result-2.png"}
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500077,
                        CourseDisplayId = 8,
                        Title = "Filtering and Ordering Data",
                        Slug = "intro-to-sql-filtering",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                           
                            new Block
                            {
                                Title = "Filtering Data with WHERE",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "One of the most powerful features of the <b>SELECT</b> statement is the <b>WHERE</b> clause. This allows you to filter the data returned based on certain conditions. It can be used to retrieve only the rows that meet specific criteria."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT ProductName, Price FROM Products\r\nWHERE StockQuantity > 100;"},
                                    new Paragraph { Body = "Running the query above using our dataset <b>should return 21 products</b>. The <b>WHERE StockQuantity > 100</b> condition filters the rows, returning only those where the <b>StockQuantity is greater than 100</b>. You can use various operators in the WHERE clause, such as =, >, <, BETWEEN, IN, LIKE, and more."},
                                }
                            },
                            new Block
                            {
                                Title = "Sorting Results with ORDER BY",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "You can sort the results of a`SELECT query using the <b>ORDER BY</b> clause. By default, SQL sorts results in ascending order (<b>ASC</b>), but you can also sort in descending order (<b>DESC</b>)."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT ProductName, Price, StockQuantity FROM Products\r\nWHERE StockQuantity > 100 \r\nORDER BY Price DESC;"},
                                    new Paragraph { Body = "Run the query above and see if the highest prices will appear first. Also try removing the DESC keyword. In this case the order will be by price ascending, by default."},
                                }
                            },
                            new Block
                            {
                                Title = "Limiting the Number of Results",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT ProductName, Price FROM Products\r\nWHERE StockQuantity > 100\r\nORDER BY Price DESC\r\nLIMIT 5;"},
                                    new Paragraph { Body = "This limits the number of rows returned to 5. You can adjust this number to suit your needs. This query will return the <b>top 5 products</b> (based on Price) with more than 100 units in stock."},
                                }
                            },
                            new Block
                            {
                                Title = "Eliminate Duplicates",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The <b>DISTINCT</b> keyword is used to eliminate duplicate rows from the result set. It is useful when you want to retrieve only unique values for a specific column or combination of columns."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT DISTINCT StockQuantity FROM Products;"
                                    },
                                    new Paragraph { Body = "Using our data set, this query will return a list of 24 distinct StockQuantity values from the Products table."},
                                }
                            },
                            new Block
                            {
                                Title = "Combining Multiple Conditions",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "<b>You can combine multiple conditions</b> in the WHERE clause using logical operators like AND and OR. This allows you to create more complex filters."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT ProductName, Price, StockQuantity FROM Products\r\nWHERE StockQuantity > 100 AND Price < 50;"},
                                    new Paragraph { Body = "This logical operator ensures that both conditions must be true for a row to be included in the result. In this case, the `StockQuantity` must be greater than 100 <b>and</b> the `Price` must be less than 50. This query will return the `ProductName`, `Price`, and `StockQuantity` of 17 products that meet both conditions in our dataset. "},
                                }
                            },
                            new Block
                            {
                                Title = "Exercises",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "<ol>\r\n  <li>✔️ Write a query to find all products with a <b>Price</b> greater than 20.</li>\r\n  <li>✔️ Write a query to retrieve products that have a <b>StockQuantity</b> between 50 and 200.</li>\r\n  <li>✔️ Write a query to list all distinct <b>StockQuantity</b> values in the <b>Products</b> table.</li>\r\n  <li>✔️ Write a query to find the top 3 most expensive products using <b>ORDER BY</b> and <b>LIMIT</b>.</li>\r\n  <li>✔️ Write a query to retrieve all products with a <b>Price</b> less than 30 or a <b>StockQuantity</b> greater than 300.</li>\r\n  <li>✔️ Write a query to find all products added to the database after the the 30th of March, 2024, using the <b>DateAdded</b> column.</li>\r\n  <li>✔️ Write a query to count the number of products with <b>StockQuantity</b> equal to 100 and a <b>Price</b> greater than 50.</li>\r\n  <li>✔️ Write a query to list all products with <b>StockQuantity</b> greater than 200 and <b>Price</b> between 20 and 80, sorted by <b>Price</b> in ascending order.</li>\r\n  <li>✔️ Write a query to find all products with <b>StockQuantity</b> less than 150 or a <b>Price</b> greater than 500, and that were added to the database before the the 30th of September, 2024.</li>\r\n  <li>✔️ Combine the use of <b>WHERE</b>, <b>ORDER BY</b>, and <b>LIMIT</b> to find the top 5 cheapest products that have more than 50 units in stock, were added to the database after the the 1st of June, 2024, and have a <b>Price</b> less than 100.</li>\r\n</ol>\r\n"}
                                }
                            },
                        }
                    },
                    new Article
                    {
                        Id = 500078,
                        CourseDisplayId = 9,
                        Title = "Aggregate Functions",
                        Slug = "intro-to-sql-aggregate-functions",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {

                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Aggregate functions in SQL are essential tools for analyzing and summarizing data. These functions perform calculations on a set of values and return a single result. They are commonly used in combination with the <b>GROUP BY</b> clause but can also work independently. This chapter will introduce key aggregate functions, explain their use cases, and provide examples to help you understand how to use them effectively."},
                                    new Paragraph { Body = "Aggregate functions operate on multiple rows of data and return a single value that summarizes the data in some way. Examples include calculating sums, averages, counts, and finding the maximum or minimum values in a column."},
                                }
                            },
                            new Block
                            {
                                Title = "Counting Rows with COUNT",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The <b>COUNT</b> function is used to count the number of rows or non-null values in a column."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT COUNT(*) AS TotalProducts\r\nFROM Products;"},
                                    new Paragraph { Body = "The output for the above query should be a single row with a single Total Products column with the value of 100. Notice we're using an Alias for the first time, using the keyword <b>AS</b> to define a custom name for the column."},
                                }
                            },
                            new Block
                            {
                                Title = "Summing Values with SUM",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The <b>SUM</b> function adds up all the values in a numeric column."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT SUM(Price * Quantity) AS TotalCatalogValue\r\nFROM Products\r\n"},
                                    new Paragraph { Body = "The result of this query should be the sum of all products multiplied by their prices. In our data set, this value would be 578079.59."},
                                }
                            },
                            new Block
                            {
                                Title = "Finding Averages with AVG",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The <b>AVG</b> function calculates the average value of a numeric column."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT AVG(Price) AS AveragePrice\r\nFROM Products;\r\n"},
                                    new Paragraph { Body = "The average product price in our catalogue should be 209.44"},
                                }
                            },
                            new Block
                            {
                                Title = "Finding Minimum and Maximum Values",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The <b>MIN</b> and <b>MAX</b> functions identify the smallest and largest values in a column, respectively."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT MIN(Price) AS CheapestProduct, MAX(Price) AS MostExpensiveProduct\r\nFROM Products;"},
                                    new Paragraph { Body = "The result should be two custom columns with the values of 19.99 and 1499.99"},
                                }
                            },
                            new Block
                            {
                                Title = "Combining Aggregate Functions",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "You can use multiple aggregate functions in a single query to get a comprehensive summary."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT COUNT(*) AS TotalProducts,\r\n       SUM(Price) AS TotalPrice,\r\n       AVG(Price) AS AveragePrice,\r\n       MIN(Price) AS CheapestProduct,\r\n       MAX(Price) AS MostExpensiveProduct\r\nFROM Products;\r\n"},
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "Unlike SUM or AVG, which require adding up or dividing numbers, MIN and MAX just scan for the smallest or largest value. They're the speediest of aggregate functions and are great for quick stats." }
                                }
                            },
                            new Block
                            {
                                Title = "Exercises",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        Body = "<ol>\r\n  <li>✔️ Write a query to count the total number of rows in the <b>Products</b> table where the <b>StockQuantity</b> is greater than 50.</li>\r\n  <li>✔️ Write a query to find the total value of the 5  most expensive products by summing the <b>Price</b> multiplied by <b>StockQuantity</b>.</li>\r\n  <li>✔️ Write a query to calculate the average <b>Price</b> of all products added in the last 6 months.</li>\r\n  <li>✔️ Write a query to retrieve the minimum and maximum <b>Date</b> of all products, displaying them in custom columns named <b>EarliestProduct</b> and <b>LatestProduct</b>.</li>\r\n  <li>✔️ Write a query to count how many products have a <b>Price</b> greater than 200.</li>\r\n  <li>✔️ Write a query to find the total value of all products added to the catalog after the 1st of July, 2024, by summing the <b>Price</b> multiplied by <b>StockQuantity</b>.</li>\r\n  <li>✔️ Write a query to calculate the average <b>Price</b> of products with a <b>StockQuantity</b> greater than 100 and less than 300.</li>\r\n  <li>✔️ Write a query to find the total number of products and their total catalog value for products added to the catalog before the 1st of November, 2024.</li>\r\n  <li>✔️ Write a query to retrieve the minimum and maximum <b>Price</b>, the average <b>Price</b>, and the total number of products for the 10 cheapest products.</li>\r\n  <li>✔️ Write a query to calculate the total number of products, total catalog value, average price, and the minimum and maximum prices for products with a <b>Price</b> greater than 100, a <b>StockQuantity</b> less than 500, and added after the 1st of October, 2024.</li>\r\n</ol>\r\n" }
                                }
                            },
                        }
                    },
                    new Article
                    {
                        Id = 500079,
                        CourseDisplayId = 10,
                        Title = "Aggregate Functions",
                        Slug = "intro-to-sql-aggregate-functions",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {

                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Aggregate functions in SQL are essential tools for analyzing and summarizing data. These functions perform calculations on a set of values and return a single result. Aggregate functions are commonly used in combination with the `GROUP BY` clause but can also work independently. This chapter will introduce key aggregate functions, explain their use cases, and provide examples to help you understand how to use them effectively."},
                                    new Paragraph { Body = "Aggregate functions operate on multiple rows of data and return a single value that summarizes the data in some way. Examples include calculating sums, averages, counts, and finding the maximum or minimum values in a column."},
                                }
                            },
                            new Block
                            {
                                Title = "Counting Rows with `COUNT`",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The COUNT function is used to count the number of rows or non-null values in a column."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT COUNT(*) AS TotalProducts\r\nFROM Products;"},
                                    new Paragraph { Body = "Output?"},
                                }
                            },
                            new Block
                            {
                                Title = "Summing Values with `SUM`",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The `SUM` function adds up all the values in a numeric column."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT SUM(Price * Quantity) AS TotalRevenue\r\nFROM Orders\r\nJOIN Products ON Orders.ProductID = Products.ProductID;"},
                                    new Paragraph { Body = "Result"},
                                }
                            },
                            new Block
                            {
                                Title = "Finding Averages with `AVG`",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The `AVG` function calculates the average value of a numeric column."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT AVG(Price) AS AveragePrice\r\nFROM Products;\r\n"},
                                    new Paragraph { Body = "Result"},
                                }
                            },
                            new Block
                            {
                                Title = "Finding Minimum and Maximum Values",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The `MIN` and `MAX` functions identify the smallest and largest values in a column, respectively."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT MIN(Price) AS CheapestProduct, MAX(Price) AS MostExpensiveProduct\r\nFROM Products;"},
                                    new Paragraph { Body = "Result"},
                                }
                            },
                            new Block
                            {
                                Title = "Combining Aggregate Functions",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "You can use multiple aggregate functions in a single query to get a comprehensive summary."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT COUNT(*) AS TotalProducts,\r\n       SUM(Price) AS TotalPrice,\r\n       AVG(Price) AS AveragePrice,\r\n       MIN(Price) AS CheapestProduct,\r\n       MAX(Price) AS MostExpensiveProduct\r\nFROM Products;\r\n"},
                                    new Paragraph { Body = "Result"},
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "Unlike SUM or AVG, which require adding up or dividing numbers, MIN and MAX just scan for the smallest or largest value. They're the speediest of aggregate functions and are great for quick stats." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500080,
                        CourseDisplayId = 11,
                        Title = "Deleting Data",
                        Slug = "intro-to-sql-deleting",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {

                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In SQL, the `DELETE` statement is used to remove data from a table. This operation is crucial when you want to clean up or remove obsolete information. While deleting data is straightforward, it’s important to understand how it works, as it can permanently remove data from your database."}
                                }
                            },
                            new Block
                            {
                                Title = "Deleting Filtered Data",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The most common use of the `DELETE` statement is to remove specific rows from a table based on a condition. The condition is specified using the `WHERE` clause, which ensures that only the rows matching that condition are deleted. Without a `WHERE` clause, all rows in the table will be deleted."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "DELETE FROM Products\r\nWHERE StockQuantity = 0;"},
                                    new Paragraph { Body = "Output?"},
                                }
                            },
                            new Block
                            {
                                Title = "Deleting All Rows from a Table",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "If you want to delete all rows in a table, you can use the `DELETE` statement without a `WHERE` clause. This will remove all data from the table but leave the table structure intact, so the table can still be used to insert new data."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "DELETE FROM Products;"},
                                    new Paragraph { Body = "Be very cautious when using this type of query, as it will erase all data from the table. This is often used for cleaning up tables but should be done with care to avoid losing valuable data."},
                                }
                            },
                            new Block
                            {
                                Title = "Deleting a Table",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In some cases, you may want to remove an entire table, including both its data and structure. To do this, you can use the `DROP` statement, which completely removes the table from the database."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "DROP TABLE Products;"},
                                    new Paragraph { Body = "This operation is more drastic than a `DELETE` statement, as it completely removes the table from the database. This is typically used when you no longer need the table or when you're restructuring your database. Once a table is dropped, it can’t be recovered unless you have backups."},
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "Deleting large numbers of rows can affect database performance, especially in tables with many records. If you need to delete millions of rows, consider doing so in smaller batches to avoid locking issues or performance slowdowns." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500081,
                        CourseDisplayId = 12,
                        Title = "Updating Data",
                        Slug = "intro-to-sql-updating",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {

                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The `UPDATE` statement in SQL allows you to modify existing records in a table. Whether you're correcting data, updating prices, or adjusting stock quantities, the `UPDATE` statement is essential for maintaining and adjusting the information stored in your database. Like the `DELETE` statement, `UPDATE` should be used with caution to avoid unintended changes."}
                                }
                            },
                            new Block
                            {
                                Title = "Updating With WHERE",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "To update data in a table, you use the `UPDATE` statement, followed by the table name and the `SET` clause to specify which columns should be modified and the new values they should take. To ensure you only update the intended rows, you should always include a `WHERE` clause. If no `WHERE` clause is provided, all rows in the table will be updated."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "UPDATE Products\r\nSET Price = 19.99WHERE ProductID = 5;"},
                                    new Paragraph { Body = "Output?"},
                                }
                            },
                            new Block
                            {
                                Title = "Updating Multiple Columns",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "You can also update multiple columns in a single `UPDATE` statement by separating each column update with a comma."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "UPDATE Products\r\nSET Price = 19.99, StockQuantity = 50WHERE ProductID = 5;"},
                                    new Paragraph { Body = "This query will change both the price and stock quantity for the product with `ProductID = 5`."},
                                }
                            },
                            new Block
                            {
                                Title = "Updating All Rows",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "If you omit the `WHERE` clause, all rows in the table will be updated with the new values specified in the `SET` clause. This can be useful in certain scenarios, but it should be used with caution."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "UPDATE Products\r\nSET StockQuantity = 100;"},
                                    new Paragraph { Body = "This operation is more drastic than a `DELETE` statement, as it completely removes the table from the database. This is typically used when you no longer need the table or when you're restructuring your database. Once a table is dropped, it can’t be recovered unless you have backups."},
                                }
                            },
                            new Block
                            {
                                Title = "Updating with Complex Conditions",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "You can use more complex conditions in the `WHERE` clause to perform more refined updates. This allows you to target rows based on multiple criteria or conditions."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "UPDATE Products\r\nSET Price = 9.99WHERE StockQuantity > 100 AND Price > 20;"},
                                    new Paragraph { Body = "This query will only update the products that meet both conditions (stock quantity greater than 100 and price greater than 20)."},
                                    new Paragraph { Body = "You can also use expressions in the `SET` clause to dynamically calculate the new values based on the existing data in the table."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "UPDATE Products\r\nSET Price = Price * 1.1WHERE StockQuantity > 100;"},
                                    new Paragraph { Body = "This query will increase the price of all products with more than 100 units in stock by 10%."},
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "SQL is faster when you’re precise about which rows to update. For instance, UPDATE Orders SET Status = 'Shipped' WHERE OrderID = 1234 is much faster than scanning an entire table with a vague condition like Status = 'Pending'" }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500082,
                        CourseDisplayId = 13,
                        Title = "Relational Data",
                        Slug = "intro-to-sql-relational-data",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {

                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In relational databases, relationships between tables are essential for structuring data efficiently. To establish these relationships, we use **foreign keys**, which link records in one table to those in another. These relationships help maintain data integrity and allow for more efficient queries and operations on the database."}
                                }
                            },
                            new Block
                            {
                                Title = "Creating Two Tables",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Let's extend the `Products` table we created earlier by adding a new table for product categories. Each product will belong to a category, which means we will establish a relationship between the `Products` table and the new `Categories` table."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "CREATE TABLE Categories (\r\n    CategoryID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    CategoryName TEXT NOT NULL\r\n);\r\n\r\nCREATE TABLE Products (\r\n    ProductID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    ProductName TEXT NOT NULL,\r\n    Price REAL NOT NULL,\r\n    StockQuantity INTEGER NOT NULL,\r\n    CategoryID INTEGER NOT NULL,\r\n    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)\r\n    ON DELETE CASCADE\r\n    ON UPDATE CASCADE\r\n);"},
                                    new Paragraph { Body = "**`FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)`**: This establishes the foreign key relationship. It tells the database that the `CategoryID` in the `Products` table refers to the `CategoryID` in the `Categories` table. This ensures that every product is linked to a valid category."},
                                    new Paragraph { Body = "**`ON DELETE CASCADE`**: If a category is deleted from the `Categories` table, all products associated with that category (i.e., having the same `CategoryID`) will be automatically deleted from the `Products` table."},
                                    new Paragraph { Body = "**`ON UPDATE CASCADE`**: If the `CategoryID` in the `Categories` table is updated, the corresponding `CategoryID` in the `Products` table will automatically be updated as well."},
                                }
                            },
                            new Block
                            {
                                Title = "What is a Foreign Key?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "A **foreign key** is a column or combination of columns in one table that refers to the primary key of another table. In our example, `CategoryID` in the `Products` table is a foreign key that points to `CategoryID` in the `Categories` table. The foreign key enforces referential integrity by ensuring that every `CategoryID` in the `Products` table matches a valid `CategoryID` in the `Categories` table."}
                                }
                            },
                            new Block
                            {
                                Title = "Cascading behaviors",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Cascading behaviors are rules that determine what happens to the related rows when a change is made to the parent table. For example, if you delete a category, should all the products in that category also be deleted automatically? Or should the foreign key value in the `Products` table just be set to `NULL`? These behaviors are defined when creating or altering a foreign key."},
                                    new Paragraph {
                                        Body = "There are several cascading options in SQL:"},
                                    new Paragraph { Body = "**CASCADE**: Automatically updates or deletes the dependent rows in the child table when the corresponding row in the parent table is updated or deleted."},
                                    new Paragraph { Body = "**SET NULL**: Sets the foreign key in the child table to `NULL` when the corresponding row in the parent table is deleted or updated."},
                                    new Paragraph { Body = "**SET DEFAULT**: Sets the foreign key in the child table to its default value when the corresponding row in the parent table is deleted or updated."},
                                    new Paragraph { Body = "****NO ACTION**: No action is taken on the dependent rows when the corresponding row in the parent table is deleted or updated. If a dependent row violates referential integrity, an error is thrown."},
                                    new Paragraph { Body = "**RESTRICT**: Similar to `NO ACTION`, but this ensures that no changes to the parent table will be allowed if there are dependent rows in the child table."},
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "With the schema defined above, a product cannot exist without a category. If you try to delete the Categories table while there’s a foreign key reference from the Products table, the database will prevent you from doing so, as the foreign key constraint ensures referential integrity. You'll see an error such as: Error: Cannot drop table Categories because it is referenced by Products." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500083,
                        CourseDisplayId = 14,
                        Title = "Joins",
                        Slug = "intro-to-sql-joins",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {

                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "One of the most powerful features of SQL is the ability to combine data from multiple tables using **joins**. In relational databases, data is often spread across different tables, and using joins allows you to retrieve and display this data in a more meaningful way. This chapter will explore the different types of joins, how they work, and when to use them."},
                                    new Paragraph { Body = "Let's look at the different types of joins, using the Categories and Products tables."}
                                }
                            },
                            new Block
                            {
                                Title = "Inner Join",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "An **inner join** retrieves only the rows where there is a match in both tables. If a record in the first table has no corresponding record in the second table, it is excluded from the results. The **inner join** is the most common type of join and is the default if no join type is specified."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT \r\n    Products.ProductID,\r\n    Products.ProductName,\r\n    Products.Price,\r\n    Categories.CategoryName\r\nFROM \r\n    Products\r\nINNER JOIN \r\n    Categories\r\nON \r\n    Products.CategoryID = Categories.CategoryID;"},
                                    new Paragraph { Body = "**`INNER JOIN Categories`**: This part tells SQL to join the `Products` table with the `Categories` table."},
                                    new Paragraph { Body = "**`ON Products.CategoryID = Categories.CategoryID`**: This is the condition that defines how the tables should be joined. The query will match rows in `Products` where the `CategoryID` field matches the `CategoryID` in the `Categories` table."},
                                    new Paragraph { Body = "The result will only include products that have a valid `CategoryID` matching a `CategoryID` in the `Categories` table."},
                                    new Paragraph { Body = "Output"}
                                },
                            },
                            new Block
                            {
                                Title = "Left Join",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "A **left join** (or **left outer join**) retrieves all rows from the **left table** (the table listed first in the query) and the matching rows from the **right table** (the table listed second). If there is no match, the result will still include all rows from the left table, but with `NULL` values for columns from the right table."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT \r\n    Products.ProductID,\r\n    Products.ProductName,\r\n    Products.Price,\r\n    Categories.CategoryName\r\nFROM \r\n    Products\r\nLEFT JOIN \r\n    Categories\r\nON \r\n    Products.CategoryID = Categories.CategoryID;\r\n"},
                                    new Paragraph { Body = "**`LEFT JOIN Categories`**: This means that all records from the `Products` table will be returned, even if they don’t have a matching row in the `Categories` table. If there’s no matching `CategoryID`, the `CategoryName` will be `NULL`."},
                                    new Paragraph { Body = "Output"},
                                }
                            },
                            new Block
                            {
                                Title = "Right Join",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "A **right join** (or **right outer join**) works the opposite way to a left join. It retrieves all rows from the **right table** and the matching rows from the **left table**. If there’s no match, the result will still include all rows from the right table with `NULL` values for columns from the left table."},
                                     new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT \r\n    Products.ProductID,\r\n    Products.ProductName,\r\n    Products.Price,\r\n    Categories.CategoryName\r\nFROM \r\n    Products\r\nRIGHT JOIN \r\n    Categories\r\nON \r\n    Products.CategoryID = Categories.CategoryID;\r\n"},
                                    new Paragraph {
                                        Body = "This means that all records from the `Categories` table will be returned, even if they don’t have a matching row in the `Products` table. If there’s no matching `ProductID`, the `ProductName`, `Price`, and other product details will be `NULL`."},
                                    new Paragraph {
                                        Body = "Output"}
                                }
                            },
                            new Block
                            {
                                Title = "Full Join (Full Outer Join)",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "A **full join** (or **full outer join**) returns all rows from both the left and right tables. If there’s a match between the tables, the corresponding rows are combined. If there’s no match, the result will include `NULL` values for columns in the table that doesn't have a match."},
                                     new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT \r\n    Products.ProductID,\r\n    Products.ProductName,\r\n    Products.Price,\r\n    Categories.CategoryName\r\nFROM \r\n    Products\r\nFULL OUTER JOIN \r\n    Categories\r\nON \r\n    Products.CategoryID = Categories.CategoryID;\r\n"},
                                    new Paragraph {
                                        Body = "This means that all records from both the `Products` and `Categories` tables will be returned, even if they don’t have a match in the other table. If there’s no match, the corresponding columns from the other table will be `NULL`."},
                                    new Paragraph {
                                        Body = "Output"}
                                }
                            },
                            new Block
                            {
                                Title = "Summary",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Use **inner joins** when you want only records that have corresponding rows in both tables."},
                                     new Paragraph {
                                        Body = "Use **left joins** when you need all records from the left table, whether or not there are matching rows in the right table."},
                                    new Paragraph {
                                        Body = "Use **right joins** when you need all records from the right table, whether or not there are matching rows in the left table."},
                                    new Paragraph {
                                        Body = "Use **full joins** when you need all records from both tables, and you’re okay with missing data in one of the tables."}
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "Join Types Are Like Relationships: SQL joins can be compared to different types of relationships. A LEFT JOIN is like an open-minded friend who listens to your stories even if you don’t return the favor. A RIGHT JOIN is the opposite: it listens to your stories but only shares their own if you’ve shared first. An INNER JOIN only cares about the stories you both agree on—no story without the other!" }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500084,
                        CourseDisplayId = 15,
                        Title = "Joins",
                        Slug = "intro-to-sql-relationships",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {

                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "We will modify the previous structure slightly by keeping the **one-to-many** relationship between **Categories** and **Products**. The **Orders** table and the join table **OrderProducts** will allow us to track products in an order."},
                                     new Paragraph {
                                        IsCode = true,
                                        Body = "CREATE TABLE Products (\r\n    ProductID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    ProductName TEXT NOT NULL,\r\n    Price REAL NOT NULL,\r\n    CategoryID INTEGER NOT NULL,\r\n    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)\r\n);\r\n\r\nCREATE TABLE Categories (\r\n    CategoryID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    CategoryName TEXT NOT NULL\r\n);\r\n\r\nCREATE TABLE Orders (\r\n    OrderID INTEGER PRIMARY KEY AUTOINCREMENT,\r\n    OrderDate TEXT NOT NULL,\r\n    CustomerName TEXT NOT NULL\r\n);\r\n\r\nCREATE TABLE OrderProducts (\r\n    OrderID INTEGER,\r\n    ProductID INTEGER,\r\n    Quantity INTEGER NOT NULL,\r\n    PRIMARY KEY (OrderID, ProductID),\r\n    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID) ON DELETE CASCADE,\r\n    FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE\r\n);\r\n"},
                                }
                            },
                            new Block
                            {
                                Title = "One-To-Many",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In this case, the **one-to-many** relationship between **Categories** and **Products** means that. Each **Product** belongs to one **Category** (via the `CategoryID` foreign key). Each **Category** can have multiple **Products**."},
                                },
                            },
                            new Block
                            {
                                Title = "Many-to-Many",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "the many-to-many relationship is represented by the OrderProducts table, which connects the Orders and Products tables. Here’s how it works, along with an explanation of composite keys."},
                                    new Paragraph {
                                        Body = "A single order can contain multiple products, and a single product can be ordered in many different orders. This creates a many-to-many relationship between Orders and Products."}
                                },
                            },
                            new Block
                            {
                                Title = "Composite Keys",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In the OrderProducts table, we are using a composite primary key, which means the combination of multiple columns is used as a unique identifier for each row. This ensures that for each combination of OrderID and ProductID, there can only be one row in the OrderProducts table. This prevents multiple entries of the same product in an order."},
                                     new Paragraph {
                                        Body = "For example, if an order has three products, there will be three rows in the OrderProducts table, one for each product in the order."},
                                    new Paragraph {
                                        Body = "This means that all records from the `Categories` table will be returned, even if they don’t have a matching row in the `Products` table. If there’s no matching `ProductID`, the `ProductName`, `Price`, and other product details will be `NULL`."},
                                    new Paragraph {
                                        Body = "The combination of OrderID and ProductID ensures that each product in an order is unique (no duplicate entries for the same product within the same order)."}
                                }
                            },
                            new Block
                            {
                                Title = "Example of a Many to Many Query",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "To find all the products ordered in a particular order:"},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT Products.ProductName, OrderProducts.Quantity\r\nFROM Products\r\nJOIN OrderProducts ON Products.ProductID = OrderProducts.ProductID\r\nWHERE OrderProducts.OrderID = 1;\r\n"},
                                    new Paragraph {
                                        Body = "This query joins the Products and OrderProducts tables, matching ProductID, and retrieves all products with their quantities for OrderID = 1."}
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "A one-to-many relationship is like a parent with many children. The parent (the \"one\" side) can have many children (the \"many\" side), but each child can only have one parent. For example, a Category can have many Products, but each Product belongs to only one Category. In a family, each person (e.g., a cousin) can have multiple cousins, and each cousin can also have multiple cousins. So, the relationship is reciprocal and can involve many-to-many interactions." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500085,
                        CourseDisplayId = 16,
                        Title = "Joins",
                        Slug = "intro-to-sql-groupby",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {

                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The `GROUP BY` clause is a powerful feature in SQL that allows you to aggregate data into groups based on the values in one or more columns. It is commonly used alongside aggregate functions such as `COUNT`, `SUM`, `AVG`, `MAX`, and `MIN` to perform calculations on grouped data. This chapter will explain how to use `GROUP BY`, why it's useful, and provide detailed examples for various use cases."},
                      
                                }
                            },
                            new Block
                            {
                                Title = "Syntax of Group By",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "To find all the products ordered in a particular order:"},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT column_name, aggregate_function(column_name)\r\nFROM table_name\r\nGROUP BY column_name;\r\n"},
                                    new Paragraph {
                                        Body = "- `column_name`: The column you want to group data by.\r\n- `aggregate_function`: A function like `COUNT`, `SUM`, `AVG`, `MAX`, or `MIN` applied to grouped data.\r\n- `GROUP BY`: Specifies the column(s) to group the rows.\r\n"}
                                }
                            },
                            new Block
                            {
                                Title = "Example 1: Counting the Number of Products in Each Category",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "This query groups the products by category and counts how many products belong to each category."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT CategoryID, COUNT(*) AS ProductCount\r\nFROM Products\r\nGROUP BY CategoryID;\r\n"},
                                    new Paragraph {
                                        Body = "- `column_name`: The column you want to group data by.\r\n- `aggregate_function`: A function like `COUNT`, `SUM`, `AVG`, `MAX`, or `MIN` applied to grouped data.\r\n- `GROUP BY`: Specifies the column(s) to group the rows.\r\n"}
                                }
                            },
                            new Block
                            {
                                Title = "Example 2: Calculating the Total Quantity Ordered for Each Product",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "This query calculates the total quantity of each product ordered, grouped by ProductID"},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT ProductID, SUM(Quantity) AS TotalQuantityOrdered\r\nFROM OrderProducts\r\nGROUP BY ProductID;\r\n"}
                                }
                            },
                            new Block
                            {
                                Title = "Example 3: Calculate Total Quantity Ordered Per Product",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "In this slightly more advanced query we first join the tables before grouping the products by their names."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT Products.Name AS ProductName, SUM(Orders.Quantity) AS TotalQuantity\r\nFROM Orders\r\nJOIN Products ON Orders.ProductID = Products.ProductID\r\nGROUP BY Products.Name;\r\n"}
                                }
                            },
                            new Block
                            {
                                Title = "Example 4: Count of Orders Per Product",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "To find out how many orders each product has, we first need to combine Products and Orders:"},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT Products.Name AS ProductName, COUNT(Orders.OrderID) AS OrderCount\r\nFROM Orders\r\nJOIN Products ON Orders.ProductID = Products.ProductID\r\nGROUP BY Products.Name;\r\n"}
                                }
                            },
                            new Block
                            {
                                Title = "Example 5: Grouping by CategoryID and ProductName",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "This query will group the Products by both CategoryID and ProductName, and count how many times each product appears in the OrderProducts table (i.e., how many orders each product has been a part of)."},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT P.CategoryID, P.ProductName, COUNT(OP.ProductID) AS OrderCount\r\nFROM Products P\r\nJOIN OrderProducts OP ON P.ProductID = OP.ProductID\r\nGROUP BY P.CategoryID, P.ProductName;\r\n"}
                                }
                            },
                        }
                    },
                    new Article
                    {
                        Id = 500086,
                        CourseDisplayId = 17,
                        Title = "Pivots",
                        Slug = "intro-to-sql-pivots",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {

                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Pivot tables are a powerful way to transform your data by turning rows into columns. This technique is particularly useful for generating summary reports or reorganizing data for better analysis. In this chapter, we’ll use our existing **Products** and **Categories** tables to explore pivot tables and learn how to use them effectively."},
                                    new Paragraph { Body = "A pivot table reorganizes data from a relational database into a summary format. In SQL, pivoting involves grouping data and converting values in a column into separate columns. This is often used for summarizing data, such as calculating sales per product or category."},

                                }
                            },
                            new Block
                            {
                                Title = "Syntax of Pivot",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "To facilitate the visualization of the syntax, let's add comments above each line:"},
                                    new Paragraph {
                                        IsCode = true,
                                        Body = "SELECT * \r\nFROM \r\n    (SELECT CategoryID, Name FROM Products) AS SourceTable\r\nPIVOT \r\n    (COUNT(Name) FOR CategoryID IN ([1], [2], [3])) AS PivotTable;"},
                                    new Paragraph {
                                        Body = "This part is a subquery that selects two columns from the Products table: CategoryID and Name. The subquery gives you the data that will be used for the pivot operation. Alias (SourceTable): This subquery is given the alias SourceTable, which means the result of this subquery is treated as a temporary table with the name SourceTable for the purpose of the PIVOT operation."},
                                    new Paragraph {
                                        Body = "PIVOT: This keyword tells SQL that you want to perform a pivot operation. The idea is to turn rows into columns based on the values in a specific column—in this case, the CategoryID.\r\n\r\n"},
                                     new Paragraph {
                                        Body = "This is the aggregate function applied to the data. You want to count how many times each product appears in each category. Instead of just displaying each row, it aggregates the data (using the count in this case)."},
                                     new Paragraph {
                                        Body = "FOR CategoryID: This specifies that you want to pivot the CategoryID values, which means the different CategoryID values will become separate columns in the result."},
                                     new Paragraph {
                                        Body = "IN ([1], [2], [3]): This specifies which values of CategoryID you want to pivot into separate columns. In this case, you are explicitly choosing CategoryID values 1, 2, and 3. These will become the column headers in the pivoted table. "},
                                     new Paragraph {
                                        Body = "AS PivotTable: This gives an alias to the result of the PIVOT operation. The final pivoted table will be called PivotTable."}
                                }
                            },
                            new Block
                            {
                                Title = "Final Result",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "The result of this pivot operation will have a row for each ProductName, and columns for each of the selected CategoryID values (in this case 1, 2, and 3). The cell values will be the count of how many products belong to each category."},
                                    new Paragraph {
                                        Body = "Outcome"}
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "You probably noticed we're hard coding the category Ids, which means we have to know them in advance. If we want to pivot a table on a property with values that aren't known in advance, we would need to pick those values up dynamically. This would require techniques that haven't been covered yet in this course. We'll be covering dynamic pivots in an advanced SQL course." }
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500087,
                        CourseDisplayId = 18,
                        Title = "Database Design",
                        Slug = "intro-to-sql-design",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {

                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "Proper database design is the cornerstone of efficient data management and application performance. This chapter explains when to create tables, how to decide relationships between them, and how to structure your database to meet business needs effectively."},
                                    new Paragraph { Body = "Keep in mind that database design is a vast topic, with several books written about it. We'll just scratch the surface to give you some tools for designing simple relational databases. "},

                                }
                            },
                            new Block
                            {
                                Title = "When to Create Tables",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "A table should represent a single, logical entity in your business domain. For example, In an eCommerce system, **Products**, **Categories**, and **Orders** are distinct entities that require separate tables. Avoid combining unrelated data into one table, as this leads to redundancy and difficulties in querying."},
                                    new Paragraph {
                                        Body = "Ask yourself these questions: Does this data describe a specific entity? If yes, create a table. Will this data need to relate to other entities? If yes, determine relationships (e.g., one-to-many, many-to-many)."}
                                }
                            },
                            new Block
                            {
                                Title = "Deciding Relationships Between Tables",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { Body = "You should always be asking yourself: Does this entity have one or more of this other entity? The answer is not always clear but it lies at the core of your design decisions: "},
                                    new Paragraph {
                                        Body = "**One-to-Many**: The most common relationship, such as a **Category** having multiple **Products**."},
                                    new Paragraph {
                                        Body = "**Many-to-Many**: Use a join table to connect entities. For example, an **Order** can contain multiple **Products**, and a **Product** can belong to multiple **Orders**."}
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       BackgroundColor="#1C236D",
                                       FontColor="#FFF",
                                       Body = "Instead of creating a Status or Type table for simple, finite options (like Pending, Completed, Cancelled), use enums or a predefined column with constraints. Reserve a separate table only if these values are dynamic or need additional attributes." }
                                }
                            }
                        }
                    }
                }
            },
            new Course
            {
                Id = 5,
                Title = "Introduction to WPF",
                Description = "Build stunning desktop apps with XAML and C# in WPF!",
                ImgUrl = "icons8-application-64.png",
                Articles = new List<Article>
                {
                    new Article
                    {
                        Id = 500100,
                        CourseDisplayId = 1,
                        Title = "Introduction",
                        Slug = "intro-to-wpf-intro",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Title = "What is WPF?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph { 
                                        Body = "Windows Presentation Foundation, or WPF, is a powerful framework for building modern desktop applications on Windows. First introduced by Microsoft as part of the .NET Framework, WPF leverages the combination of <b>XAML (a declarative markup language)</b> and C# to create visually rich and interactive user interfaces. WPF is designed to provide flexibility in UI design, offering capabilities such as data binding, advanced graphics, animations, and styling." 
                                    },
                                    new Paragraph {
                                       Body = "At its core, WPF is built on a <b>vector-based rendering engine</b>, which allows for scalable, resolution-independent visuals. This means that the interface looks sharp and performs consistently across different screen resolutions. With support for both 2D and 3D graphics, developers can create applications that are not just functional but also visually stunning." 
                                    },
                                     //new Paragraph {
                                     //   IsPicture = true,
                                     //   PictureUrl = "sql-image.jpeg"}
                                }
                            },
                            new Block
                            {
                                Title = "Why Learn WPF?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph
                                    {
                                       Body = "WPF remains a key technology for developers building robust and feature-rich desktop applications. Its comprehensive tools and components enable developers to focus on crafting user experiences rather than worrying about the complexities of UI management."
                                    },
                                    new Paragraph
                                    {
                                       Body = "WPF is also highly extensible, supporting both enterprise-grade applications and smaller personal projects. Despite the rise of web and mobile technologies, WPF is still widely used in industries like finance, healthcare, and engineering, where desktop applications are preferred for their reliability, performance, and offline capabilities."
                                    },
                                    new Paragraph
                                    {
                                       Body = "While WPF may not enjoy the hype of newer technologies, it remains a reliable and powerful framework with a dedicated community and a solid place in enterprise development. Its longevity is a testament to its design and capability, making it an excellent choice for developers focused on building sophisticated desktop applications."
                                    },
                                }
                            },
                            new Block
                            {
                                Title = "Key Features of WPF",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "WPF provides developers with a set of tools that simplify application development. Some of the most notable features include:<br> ➡️ <b>Data Binding</b>: Connect UI components directly to data sources, ensuring real-time updates and synchronization.<br>➡️ <b>Styles and Templates</b>: Customize and theme your application to maintain a consistent look and feel.<br>➡️ <b>Animations and Graphics</b>:Build dynamic and visually appealing applications with support for animations and rich media.<br>➡️ <b>Layouts</b> Arrange UI components dynamically, ensuring the application looks great on any window size or resolution.\r\n" }
                                }
                            },
                            new Block
                            {
                                Title = "Other frameworks",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Microsoft has provided numerous frameworks and technologies over the years for building desktop applications on Windows. Early on, developers used Win32 API, a low-level C-based interface offering direct control over Windows components. Then came MFC (Microsoft Foundation Classes), a C++ wrapper around Win32 that simplified UI programming while still requiring manual memory management and COM interactions. Later, Microsoft introduced Windows Forms (WinForms) with .NET, which brought a higher-level, event-driven programming model and RAD (rapid application development) tools in Visual Studio, making it easier for developers to build GUI applications with drag-and-drop interfaces. Other notable options include UWP (Universal Windows Platform), which aimed to unify development across PCs, tablets, Xbox, and other Windows 10+ devices, but suffered from limited adoption and ecosystem constraints. More recently, Microsoft introduced WinUI, part of the Windows App SDK, which evolves UWP into a modern, flexible framework that works well with both Win32 and .NET apps." },
                                    new Paragraph {
                                       Body = "With so many options? Why pick WPF? In The C# Academy's opinion, WPF is the most mature and reliable of the above. Even considering the downside of being limited to building Windows Apps, a production app demands a battle-tested framework and that can be said of WPF. It's also important to learning WPF means learning XAML, which is used by a few of frameworks above. Even if you decide to switch later, the knowledge from WPF will transfer to the chosen framework." }
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        BackgroundColor="#1C236D",
                                        FontColor="#FFF",
                                        Body = "Did you know that WPF was originally codenamed \"Avalon\" during its development at Microsoft! Before it was formally introduced with .NET Framework 3.0 in 2006, Avalon was envisioned as the next big leap in desktop UI—bringing together declarative XAML, advanced graphics with DirectX, and a fully vector-based rendering engine. Kind of like a secret identity before it put on the WPF cape. \U0001f9b8‍♂️" }
                                }
                            },
                        }
                    },
                    new Article
                    {
                        Id = 500101,
                        CourseDisplayId = 2,
                        Title = "About the Course",
                        Slug = "intro-to-wpf-about",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Title = "What to Expect?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        Body = "This course is designed as a hands-on introduction to Windows Presentation Foundation (WPF). Instead of overwhelming you with abstract concepts or exhaustive theory, we’ll focus on building a practical and engaging project from start to finish. By the end of the course, you’ll have a fully functional desktop application that showcases the power and versatility of WPF."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "What Will We Build?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "The project we’ll create is a recipes manager—an application that allows users to manage, edit, and save their favorite recipes. Through this project, you’ll explore WPF’s key features, including dynamic layouts, user interaction through controls, and data persistence using SQLite with Entity Framework."
                                    },
                                    new Paragraph {
                                       Body = "This course takes a practical approach, skipping the advanced **Model-View-ViewModel (MVVM)** design pattern, which is commonly used in WPF applications. Instead, we’ll stick to a straightforward code-behind pattern to make it easier for you to understand the core mechanics of WPF. While MVVM is a powerful tool for building scalable and maintainable applications, it can be complex for beginners. For now, our goal is to focus on the basics and build a strong foundation."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Pre-requisites",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "- It’s important to note that this course is not for absolute beginners. To get the most out of the lessons, you should already have a working knowledge of:\r\n    - **C#:** Understanding classes, methods, events, and basic object-oriented programming is essential.\r\n    - **SQL:** You should be familiar with basic SQL concepts, such as creating tables and performing CRUD (Create, Read, Update, Delete) operations.\r\n    - **Entity Framework:** A basic understanding of how Entity Framework works, including setting up a database context and performing queries, will be helpful.\r\n"
                                    },
                                }
                            },
                            new Block
                            {
                                Title = "ADD APP PHOTO",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "ADD APP PHOTO. Talk about VS INSTALLATION"
                                    },
                                }
                            },
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        BackgroundColor="#1C236D",
                                        FontColor="#FFF",
                                        Body = "Bill Gates had to be convinced Yep, the big guy himself. The WPF team needed to pitch the vision of a unified UI framework that could handle documents, media, and interactivity. Gates eventually gave the green light, and WPF became part of .NET Framework 3.0 in 2006." }
                                }
                            },
                        }
                    },
                    new Article
                    {
                        Id = 500102,
                        CourseDisplayId = 3,
                        Title = "Project Creation",
                        Slug = "intro-to-wpf-project-creation",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        Body = "In this chapter, we’ll walk through the process of creating your very first WPF project and running it. We won’t dive into any coding yet; instead, we’ll focus on getting the project set up correctly in Visual Studio, ensuring that everything is ready to go before we start building our application."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Selecting WPF",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "Launch Visual Studio on your machine. Once Visual Studio is open, click on the **Create a new project** button. This will bring up the project template wizard. When searching for WPF you'll see a few options: WPF with Visual Basic (VB), WPF App (.NET Framework) and WPF Applicaton with C#. Select Select WPF Application (not .NET Framework). "
                                    },
                                    new Paragraph {
                                       Body = "This course takes a practical approach, skipping the advanced **Model-View-ViewModel (MVVM)** design pattern, which is commonly used in WPF applications. Instead, we’ll stick to a straightforward code-behind pattern to make it easier for you to understand the core mechanics of WPF. While MVVM is a powerful tool for building scalable and maintainable applications, it can be complex for beginners. For now, our goal is to focus on the basics and build a strong foundation."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "Configuring Your Project",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "After selecting the WPF App template, you'll be prompted to name your project. - **Project Name:** You can name your project something like `RecipeManagerApp`.\r\n- **Location:** Choose a directory where you want to save your project.\r\n- **Solution Name:** Visual Studio will automatically set the solution name to match your project name, but you can change it if needed.\r\n- Once you’ve configured your project, click **Create**.\r\n" },

                                        new Paragraph {
                                       Body = "Visual Studio will now generate a default WPF project for you. It will include several files and folders, but the most important for us right now is the `MainWindow.xaml` file, which contains the UI layout of the application, and the `MainWindow.xaml.cs` file, where we will write the logic to control how the application behaves."
                                    },
                                }
                            },
                            new Block
                            {
                                Title = "Running Your Project",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "In Visual Studio, go to the **Build** menu and select **Build Solution** (or simply press `Ctrl + Shift + B`). This will compile your application and check for any errors."
                                    },
                                    new Paragraph {
                                       Body = "To run the application, click the green **Start** button in Visual Studio, or press `F5`. This will start the app and launch the `MainWindow.xaml` by default. You should see a blank window appear with the default WPF UI layout. It won’t have any functionality yet, but the project is now set up and running."
                                    },
                                     new Paragraph {
                                       Body = "After verifying that the application runs successfully, close the window. We’re now ready to start customizing the project to suit our needs."
                                    },
                                }
                            }
                        }
                    },
                    new Article
                    {
                        Id = 500103,
                        CourseDisplayId = 4,
                        Title = "Exploring the Template",
                        Slug = "intro-to-wpf-exploring",
                        Description = "",
                        Area = Area.Course,
                        ExperiencePoints = 1,
                        Blocks = new List<Block>
                        {
                            new Block
                            {
                                Title = "MainWindow.xaml",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                        Body = "`MainWindow.xaml` is the primary file where the user interface (UI) of your WPF application is defined. It uses **XAML (Extensible Application Markup Language)**, a declarative markup language, to describe the structure and layout of the UI elements such as buttons, text boxes, labels, and grids. In this file, you can arrange controls, set properties like size and color, and apply styles. This file serves as the blueprint for the window users will interact with in the application."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "App.xaml",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "`App.xaml` is responsible for defining application-wide resources, styles, and global settings that can be shared across all windows and controls in the application. It typically includes things like color schemes, fonts, and custom resources that can be accessed anywhere in the app. This file also specifies which window should open when the application starts, typically the `MainWindow`. It serves as the entry point for application-level settings and resources."
                                    }
                                }
                            },
                            new Block
                            {
                                Title = "App.xaml.cs",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "The `App.xaml.cs` file contains the application logic, handling startup and shutdown events. This file includes the code that runs when the application is launched, such as initializing application-level resources and defining which window should appear first. For example, it may launch `MainWindow.xaml` when the application starts, and clean up resources when the application closes. It serves as the entry point for the app's life cycle."
                                    },
                                }
                            },
                            new Block
                            {
                                Title = "So what's XAML?",
                                Paragraphs = new List<Paragraph>
                                {
                                    new Paragraph {
                                       Body = "XAML (Extensible Application Markup Language) is a markup language used to define the structure and appearance of user interfaces in WPF applications. It’s a declarative language, meaning you describe the elements of your UI in a hierarchical, readable format rather than writing procedural code to create and manipulate each UI element manually. XAML is tightly integrated with C# in WPF, with C# handling the logic and XAML defining the layout. In a WPF project, XAML files describe elements such as buttons, grids, text boxes, and other controls, along with their properties like size, color, and alignment."
                                    },
                                    new Paragraph {
                                       Body = "XAML is designed to be both human-readable and machine-readable, making it easy for designers and developers to collaborate on a project. Designers can focus on laying out the interface in XAML, while developers work on the functionality in C#. One of the main advantages of XAML is that it allows for a clear separation of concerns between the UI and logic, making it easier to maintain and scale applications. It also allows for powerful features like data binding, where UI elements are linked directly to data sources, ensuring the interface automatically updates when the underlying data changes"
                                    },
                                }
                            }
                        }
                    }
                }
            }
        };
    }
}
