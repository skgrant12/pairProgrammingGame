using storyVariables;

// Initializing + declaring player, and player attributes
Player user = new Player(1, 1, 1, 1, 100);
int endurance = user.GetEndurance();
int speed = user.GetSpeed();
int intelligence = user.GetIntelligence();
int gradeLevel = user.GetGrade();
int focus = user.GetFocus();

//Intro
Console.WriteLine("Hello! Welcome to Eleven Fifty Trail!");

//Getting players name
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();
Console.WriteLine($"Hello {userName}!");

//Rules
Console.WriteLine("In Eleven Fifty Trail you will be tasked with completing projects while maintaining your health, and working on passing the class.");
Console.WriteLine("You are in Eleven Fifty Academy's Coding Foundations course. Over the course of the next 5 weeks, you will learn the basics of coding.");
Console.WriteLine("Being on time to class won't be your own problem. You will have to grow your skills to pass challenges throughout the course.");
Console.WriteLine("Failure to overcome the obstacles will result in a deduction in your grade level. The equivalent to failing class is losing 3 grade levels.");
Console.WriteLine("You will start with a grade of A, and if you fall below a grade of C, you will fail and have to retake the class.");
Console.WriteLine("Don't worry - through extra credit opportunities and listening to guest speakers you could raise your grade level!");
Console.WriteLine("_____________________________________________________________");

// Gameplay 

// Day 1 - morning
Console.WriteLine("Welcome to your first day of class. Your instructors will be Adam and Kate. ");
Console.WriteLine("As you go through your first day, you install all your essential software and create a README.md file.");
Console.WriteLine("_____________________________________________________________");
Console.WriteLine("Good morning! How would you like to spend your time before your first day of class? Class starts at 9am.");
Console.WriteLine("1. Sleep in and join the zoom at 8:58am.");
Console.WriteLine("2. Wake up extra early and read through the Canvas course.");
Console.WriteLine("3. Drink some coffee.");
Console.WriteLine("4. Check your current skill levels.");
Console.WriteLine("_____________________________________________________________");
dayOneMorning:
string dayOneMorning = Console.ReadLine();

{
    switch (dayOneMorning)
    {
        case "1":
            Console.WriteLine("You got a lot of rest but are disoriented joining the Zoom at the last possible second.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            break;
        case "2":
            Console.WriteLine("You're really tired, but feel extra prepared starting the day.");
            user.SetIntelligence(1);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            user.SetEndurance(-1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}");
            break;
        case "3":
            Console.WriteLine("You chug 3 cups of coffee and are ready ace the typing tests.");
            user.SetSpeed(1);
            Console.WriteLine($"Your typing speed is now {user.GetSpeed()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayOneMorning;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto dayOneMorning;
    }
}

Console.WriteLine("_____________________________________________________________");
int currentDay = 1;
Console.WriteLine("You finally get a lunch break, what do you do?");
Console.WriteLine("1. Take a nap.");
Console.WriteLine("2. Eat a hearty lunch.");
Console.WriteLine("3. Drink some coffee.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");

dayOneLunch:
string dayOneLunch = Console.ReadLine();

{
    switch (dayOneLunch)
    {
        case "1":
            Console.WriteLine("You overslept and came back from lunch an hour late.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance}.");
            break;
        case "2":
            Console.WriteLine("You are full and energized for class. You continue your day as usual.");
            break;
        case "3":
            Console.WriteLine("You chug 2 cups of coffee and your typing speed reflects that.");
            user.SetSpeed(1);
            Console.WriteLine($"Your Speed is now {user.GetSpeed}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            break;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto dayOneLunch;
    }
}

Console.WriteLine("_____________________________________________________________");

// Day 1 - evening

Console.WriteLine("After coming back from lunch, you create a GitHub account and learn how to make your project repositories.");
Console.WriteLine("You then learn how to initialize and push your repositories to GitHub by using your system's terminal.");
Console.WriteLine("After a great first day of learning the basics, class is done.");
Console.WriteLine("_____________________________________________________________");
Console.WriteLine("Class is now over - what do you do the rest of the night?");
Console.WriteLine("1. Play video games.");
Console.WriteLine("2. Look over tomorrow's lesson plan.");
Console.WriteLine("3. Go to bed early to be well-rested for tomorrow.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");

dayOneNight:
string dayOneNight = Console.ReadLine();

{
    switch (dayOneNight)
    {
        case "1":
            Console.WriteLine("You played 'just one more game' 6 times.");
            user.SetEndurance(-1);
            Console.WriteLine($"Your endurance is now {user.GetEndurance()}.");
            break;
        case "2":
            Console.WriteLine("Looking over tomorrow's lesson leaves you feeling prepared for the next day.");
            user.SetIntelligence(1);
            Console.WriteLine($"Your Intelligence is now({user.GetIntelligence()}.");
            break;
        case "3":
            Console.WriteLine("You get a full 8 hours of sleep and are eager to learn some HTML!");
            user.SetEndurance(1);
            Console.WriteLine($"Your endurance is now {user.GetEndurance()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayOneNight;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto dayOneNight;
    }
}
Console.WriteLine("_____________________________________________________________");

// Day 2 - Morning
Console.WriteLine("Congrats, you made it to day 2! How would you like to start your day?");
Console.WriteLine("1. Spend the whole first 25 minutes on a typing test.");
Console.WriteLine("2. Spend your typing time getting ahead on HTML.");
Console.WriteLine("3. Make your breakfast since you woke up late.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");
dayTwoMorning:
string dayTwoMorning = Console.ReadLine();

{
    switch (dayTwoMorning)
    {
        case "1":
            Console.WriteLine("Your WPM increases by 10! Good job.");
            user.SetSpeed(2);
            Console.WriteLine($"Your typing speed is now {user.GetSpeed()}.");
            break;
        case "2":
            Console.WriteLine("Your typing skill does not improve, however you grasp the first module already.");
            user.SetIntelligence(2);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            break;
        case "3":
            Console.WriteLine("You are full and energized, however you don't improve your typing skill.");
            user.SetFocus(1);
            Console.WriteLine($"Your focus skill is now {user.GetFocus()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayTwoMorning;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto dayTwoMorning;
    }
}

Console.WriteLine("_____________________________________________________________");

// Assignment One
currentDay = 2;
Console.WriteLine("It's time for your first assignment, the static register page!");

int assignmentOne = 2;
int intelligenceOne = user.GetIntelligence();
if (assignmentOne / intelligenceOne <= 1)
{
    Console.WriteLine("Congrats, you got 100% on your assignment!");
}
else if (assignmentOne / intelligenceOne <= 1.5)
{
    Console.WriteLine("You completed the assignment, but you got a B.");
    user.SetGrade(-5);
    Console.WriteLine($"Your current grade is {user.GetGrade}");
}
else {
    Console.WriteLine("You completed the assignment but barely passed.");
    user.SetGrade(-10);
    Console.WriteLine($"Your current grade is {user.GetGrade}");
};

Console.WriteLine("_____________________________________________________________");

// Day 2 - Lunch

Console.WriteLine("After a long morning of learning HTML, and completing your first assignment, it's time for lunch.");
Console.WriteLine("1. Skip lunch and keep coding.");
Console.WriteLine("2. Take a nap.");
Console.WriteLine("3. Get Chick Fil A.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");
dayTwoAfternoon:
string dayTwoAfternoon = Console.ReadLine();

{
    switch (dayTwoAfternoon)
    {
        case "1":
            Console.WriteLine("Your brain is tired, but you've improved your knowledge of HTML.");
            user.SetIntelligence(2);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            user.SetEndurance(-1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            break;
        case "2":
            Console.WriteLine("You wake up just in time for class.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            break;
        case "3":
            Console.WriteLine("You're a little sluggish from the Chick Fil-A.");
            user.SetFocus(-1);
            Console.WriteLine($"Your Focus skill is now {user.GetFocus()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayTwoAfternoon;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto dayTwoAfternoon;
    }
}

Console.WriteLine("_____________________________________________________________");

// Day 2 - Dinner

Console.WriteLine("You spend the rest of the day learning more HTML elements. Tomorrow, you will learn CSS.");
Console.WriteLine("Now that class is dismissed, how do you spend your night?");
Console.WriteLine("1. Go straight to bed. Your brain is fried.");
Console.WriteLine("2. Get ahead in tomorrow's module.");
Console.WriteLine("3. Hang out with friends.");
Console.WriteLine("4. Check your current skill levels.");
Console.WriteLine("_____________________________________________________________");
dayTwoNight:
string dayTwoNight = Console.ReadLine();

{
    switch (dayTwoNight)
    {
        case "1":
            Console.WriteLine("Your brain really needed that rest after a long day of learning!");
            user.SetEndurance(1);
            Console.WriteLine($"Your intelligence is now {user.GetEndurance()}.");
            user.SetFocus(1);
            Console.WriteLine($"Your Endurance is now {user.GetFocus()}.");
            break;
        case "2":
            Console.WriteLine("You end up getting confused on the new material and pass out from exhaustion.");
            user.SetEndurance(-1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            user.SetIntelligence(-1);
            Console.WriteLine($"Your Endurance is now {user.GetIntelligence()}.");
            break;
        case "3":
            Console.WriteLine("You had a fun night, but stayed up until 2am on Discord.");
            user.SetEndurance(-1);
            Console.WriteLine($"Your intelligence is now {user.GetEndurance()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayTwoNight;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto dayTwoNight;
    }
}

Console.WriteLine("_____________________________________________________________");

// Day 3 - Morning
currentDay = 3;
Console.WriteLine("Welcome to day 3!");
Console.WriteLine("1. Spend the whole first 25 minutes on a typing test.");
Console.WriteLine("2. Do some HTML exercises on W3 Schools");
Console.WriteLine("3. Eat some hot pockets while watching YouTube.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");
dayThreeMorning:
string dayThreeMorning = Console.ReadLine();

{
    switch (dayThreeMorning)
    {
        case "1":
            Console.WriteLine("Your WPM increases by 10! Good job.");
            user.SetSpeed(1);
            Console.WriteLine($"Your typing speed is now {user.GetSpeed()}.");
            break;
        case "2":
            Console.WriteLine("Your typing skill does not improve, but you have a better understanding of HTML elements.");
            user.SetIntelligence(1);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            break;
        case "3":
            Console.WriteLine("You enjoy your hot pockets while you watch PewDiePie.");
            user.SetFocus(-1);
            Console.WriteLine($"Your focus skill is now {user.GetFocus()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayThreeMorning;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto dayThreeMorning;
    }
}

Console.WriteLine("_____________________________________________________________");

// Static Storefront Assignment
currentDay = 3;
Console.WriteLine("You get work time for your next big project: the Static Storefront Page.");
Console.WriteLine("The assignment is due on day 5.");
Console.WriteLine("_____________________________________________________________");
int staticStorefront = 6;
int dayThreeWorkTimeIntelligence = user.GetIntelligence();
Console.WriteLine("How do you spend your work time?");
Console.WriteLine("1. Spend the whole time working on the assignment without a break.");
Console.WriteLine("2. Take a nap and do the assignment later.");
Console.WriteLine("3. Check Stats");
Console.WriteLine("_____________________________________________________________");
dayThreeWorkTime:
string dayThreeWorkTime = Console.ReadLine();
{
    switch (dayThreeWorkTime)
    {
        case "1":
            Console.WriteLine("You give it your all, and you come a long way.");
            user.SetSpeed(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            if (staticStorefront <= 0)
            {
                Console.WriteLine("Congrats, you finished the project in one sitting!");
                }
            else {
                Console.WriteLine("You still have some work left to do.");
            }
            staticStorefront = staticStorefront - dayThreeWorkTimeIntelligence;
            break;
        case "2":
            Console.WriteLine("You sleep during worktime, and didn't make any progress.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            break;
        case "3":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayThreeMorning;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto dayThreeMorning;
    }
}

Console.WriteLine("_____________________________________________________________");
Console.WriteLine("You feel good about how you spent the day's worktime.");
Console.WriteLine("How do you want to spend the night?");
Console.WriteLine("1. Spending the morning with type time.");
Console.WriteLine("2. Do some HTML exercises through W3 Schools.");
Console.WriteLine("3. Eat some hotpockets and watch YouTube.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");
{
    switch (dayThreeMorning)
    {
        case "1":
            Console.WriteLine("Your WPM increases by 10! Good job.");
            user.SetSpeed(1);
            Console.WriteLine($"Your typing speed is now {user.GetSpeed()}.");
            break;
        case "2":
            Console.WriteLine("Your typing skill does not improve, but you have a better understanding of HTML elements.");
            user.SetIntelligence(1);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            break;
        case "3":
            Console.WriteLine("You enjoy your hotpockets while you watch PewDiePie.");
            user.SetFocus(-1);
            Console.WriteLine($"Your focus skill is now {user.GetFocus()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayThreeMorning;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto dayThreeMorning;
    }
}

Console.WriteLine("_____________________________________________________________");

// Day 3 - Night
currentDay = 3;
Console.WriteLine("You get work time for your next big project: the Static Storefront Page.");
Console.WriteLine("The assignment is due on day 5.");

dayThreeNight:
Console.WriteLine("Phew! You are done with work time. How do you want to spend the night?");
Console.WriteLine("1. Work on the assignment for 2 more hours.");
Console.WriteLine("2. Go straight to bed.");
Console.WriteLine("3. Play Minecraft.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");
string dayThreeNight = Console.ReadLine();
int dayThreeNightIntelligence = user.GetIntelligence();

{
    switch (dayThreeNight)
    {
        case "1":
            Console.WriteLine("You spend a couple hours working on the assignment.");
            staticStorefront = staticStorefront - dayThreeNightIntelligence;
            if (staticStorefront <= 0)
            {
                Console.WriteLine("You ");
                }
            else {
                Console.WriteLine("You still have some work left to do.");
            }
            break;
        case "2":
            Console.WriteLine("You have a hard time sleeping because you've been staring at a screen all day.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Intelligence is now {user.GetEndurance()}.");
            break;
        case "3":
            Console.WriteLine("You find a village, and then go mining for diamonds.");
            user.SetIntelligence(1);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            Console.WriteLine("Your diamond count is still zero.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed skill is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayThreeNight;
        default:
            Console.WriteLine("Enter a number between 1 and 4.");
            goto dayThreeNight;
    }
}

Console.WriteLine("_____________________________________________________________");

// Day Four - Morning 
currentDay = 4;

Console.WriteLine("Welcome to Day 4! You are learning a few more CSS tricks today.");
Console.WriteLine("You have a lecture from 9:30-12. How do you spend that time?");

Console.WriteLine("1. Take diligent notes in your code.");
Console.WriteLine("2. Listen to the lecture, but spend time on your Static Storefront assignment.");
Console.WriteLine("3. Play more Minecraft.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");
dayFourLecture:
string dayFourLecture = Console.ReadLine();
int dayFourLectureIntelligence = user.GetIntelligence();

    switch (dayFourLecture)
    {
        case "1":
            Console.WriteLine("You absorb the content well!");
            user.SetIntelligence(2);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            break;
        case "2":
            Console.WriteLine("You make progress on your project, but didn't absorb the new content today.");
            user.SetIntelligence(1);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            user.SetFocus(-1);
            Console.WriteLine($"Your Intelligence is now {user.GetFocus()}.");
            staticStorefront = staticStorefront - dayFourLectureIntelligence;
            break;
        case "3":
            Console.WriteLine("You find 3 diamonds, but can't barter for CSS knowledge.");
            user.SetFocus(-1);
            Console.WriteLine($"Your focus skill is now {user.GetFocus()}.");
            Console.WriteLine("Your diamond count is now 3.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayFourLecture;
        default:
            Console.WriteLine("Enter a number between 1 and 4.");
            goto dayFourLecture;
    }

Console.WriteLine("_____________________________________________________________");

// Day 4 Lunch 

currentDay = 4;

Console.WriteLine("How do you spend your lunch time?");

Console.WriteLine("1. Take another nap.");
Console.WriteLine("2. Spend time on your Static Storefront assignment.");
Console.WriteLine("3. Taco Tuesday!");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");

dayFourLunch:
string dayFourLunch = Console.ReadLine();
int dayFourLunchIntelligence = user.GetIntelligence();

    switch (dayFourLunch)
    {
        case "1":
            Console.WriteLine("You are now well-rested, but hungry!");
            user.SetFocus(-1);
            Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
            break;
        case "2":
            Console.WriteLine("You make progress on your project, but are hungry and mentally drained.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            staticStorefront = staticStorefront - dayFourLunchIntelligence;
            break;
        case "3":
            Console.WriteLine("You eat a burrito for Taco Tuesday :( ");
            user.SetFocus(-1);
            Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
            Console.WriteLine("Your diamond count is now 3.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayFourLunch;
        default:
            Console.WriteLine("Enter a number between 1 and 4.");
            goto dayFourLunch;
    }

Console.WriteLine("_____________________________________________________________");

// CSS Checkup
currentDay = 4;

Console.WriteLine("After coming back from lunch, you watch YouTube videos.");
Console.WriteLine("Your next assignment is a CSS Checkup, and it's due tomorrow at 9am.");
Console.WriteLine("_____________________________________________________________");

int cssCheckup = 3;
int dayFourNightIntelligence = user.GetIntelligence();
Console.WriteLine("_____________________________________________________________");
Console.WriteLine("Now that class is over, how do you wish to spend your time?");
Console.WriteLine("1. Work on the CSS Checkup.");
Console.WriteLine("2. Spend time on your Static Storefront assignment.");
Console.WriteLine("3. Go to bed!");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");

dayFourNight: 
string dayFourNight = Console.ReadLine();

    switch (dayFourNight)
    {
        case "1":
            Console.WriteLine("You spend your night workgin on the CSS Checkup, giving it your all.");
            user.SetEndurance(-1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            cssCheckup = cssCheckup - dayFourNightIntelligence;
            if (cssCheckup <=0)
            {
                Console.WriteLine("Congrats, you finished your CSS checkup, however you're pretty exhausted.");
            }
            else 
            {
                Console.WriteLine("You made good progress on the assignment, and called it a night");
            }
            break;
        case "2":
            Console.WriteLine("You make progress following the new tricks you learn during the previous day.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            staticStorefront = staticStorefront - dayFourNightIntelligence;
            if (staticStorefront <=0) {
                Console.WriteLine("Congrats, you finished your project in one sitting!");
            }
            else 
            {
                Console.WriteLine("You still have some work left to do for the Storefront.");
            }
            break;
        case "3":
            Console.WriteLine("You make progress following the new tricks you learned during the lecture, but feel drained.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            Console.WriteLine("Your diamond count is now 3.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayFourNight;
        default:
            Console.WriteLine("Enter a number between 1 and 4.");
            goto dayFourNight;
    }

Console.WriteLine("_____________________________________________________________");

// DAY 5 - morning 

currentDay = 5;

Console.WriteLine("Welcome to day five Eleven Fifty Trail. Today, both your static storefront and CSS Checkup are due.");
Console.WriteLine("How would you like to spend the morning?");

Console.WriteLine("1. Work on the CSS Checkup.");
Console.WriteLine("2. Spend time on your Static Storefront assignment.");
Console.WriteLine("3. Sleep in since you were on top of everything.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");

dayFiveMorning:
string dayFiveMorning = Console.ReadLine();
int dayFiveMorningIntelligence = user.GetIntelligence();

    switch (dayFiveMorning)
    {
        case "1":
            Console.WriteLine("You woke up early to work on the CSS Checkup, giving it your all.");
            user.SetEndurance(-1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            cssCheckup = cssCheckup - dayFiveMorningIntelligence;
            if (cssCheckup <=0)
            {
                Console.WriteLine("Congrats, you finished your CSS checkup, however you regret the lack of sleep.");
            }
            else 
            {
                Console.WriteLine("You still have some work to do to finish the project and regret getting up early.");
            }
            break;
        case "2":
            Console.WriteLine("You make progress following the new tricks you learn during the previous day.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            staticStorefront = staticStorefront - dayFiveMorningIntelligence;
            if (staticStorefront <=0) {
                Console.WriteLine("Congrats, you finished your Static Storefront Project!");
            }
            else 
            {
                Console.WriteLine("You still have some work left to do for the Storefront.");
            }
            break;
        case "3":
            Console.WriteLine("You reward yourself with sleep for being on top of your assignments.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            user.SetFocus(1);
            Console.WriteLine($"Your Endurance is now {user.GetFocus()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayFiveMorning;
        default:
            Console.WriteLine("Enter a number between 1 and 4.");
            goto dayFiveMorning;
    }
Console.WriteLine("_____________________________________________________________");

// Static Storefront Grade
Console.WriteLine("You got your grades back for the Static Storefront.");
if (staticStorefront <= 0)
{
    Console.WriteLine("Congrats, you got 100% on the Static Storefront Assignment!");
}
else if (staticStorefront <= 1)
{
    Console.WriteLine("You completed the assignment, and got a B.");
    user.SetGrade(-5);
    Console.WriteLine($"Your current grade is {user.GetGrade}");
}
else if (staticStorefront <= 6)
{
    Console.WriteLine("You didn't do any work on your assignment.");
    user.SetGrade(-10);
    Console.WriteLine($"Your current grade is {user.GetGrade}");
}
else {
    Console.WriteLine("You completed the assignment but barely passed.");
    user.SetGrade(-7);
    Console.WriteLine($"Your current grade is {user.GetGrade}");
};

Console.WriteLine("_____________________________________________________________");

// CSS Checkup Grade
Console.WriteLine("You got your grades back for the CSS Checkup.");
if (cssCheckup <= 0)
{
    Console.WriteLine("Congrats, you got 100% on the CSS Checkup!");
}
else if (cssCheckup <= 1)
{
    Console.WriteLine("You completed the CSS Checkup, and got a B.");
    user.SetGrade(-3);
    Console.WriteLine($"Your current grade is {user.GetGrade}");
}
else if (cssCheckup == 3)
{
    Console.WriteLine("You didn't do any work on your CSS Checkup.");
    user.SetGrade(-8);
    Console.WriteLine($"Your current grade is {user.GetGrade}");
}
else {
    Console.WriteLine("You completed the CSS Checkup but barely passed.");
    user.SetGrade(-5);
    Console.WriteLine($"Your current grade is {user.GetGrade}");
};

Console.WriteLine("Congrats, you have no current assignments and will be able to enjoy the weekend!");

Console.WriteLine("_____________________________________________________________");

// Day 5 Afternoon 

currentDay = 5;
Console.WriteLine("After the morning typing test, you wrap up learning about CSS.");
Console.WriteLine("Before you head out to lunch, Adam talks about learning CSharp next week.");
Console.WriteLine("He tells you that you're not going to get it, but he's not trying to scare you.");

Console.WriteLine("After lunch, you have a guest speaker. How do you choose to spend that time?"); 

Console.WriteLine("1. Listen intently and take notes." );
Console.WriteLine("2. Leave the zoom on, but take a nap.");
Console.WriteLine("3. Listen to the speaker and stay late to ask questions.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");

dayFiveAfternoon:
string dayFiveAfternoon = Console.ReadLine();
int dayFiveAfternoonIntelligence = user.GetIntelligence();

    switch (dayFiveAfternoon)
    {
        case "1":
            Console.WriteLine("You learned a great deal from the speaker and are inspired for the weekend!");
            user.SetIntelligence(1);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            break;
        case "2":
            Console.WriteLine("You get some needed rest, but you missed the speaker!");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            user.SetIntelligence(-1);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            break;
        case "3":
            Console.WriteLine("You learn a great deal from the speaker and make a connection on LinkedIn!");
            user.SetFocus(1);
            Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
            user.SetIntelligence(1);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto dayFiveAfternoon;
        default:
            Console.WriteLine("Enter a number between 1 and 4.");
            goto dayFiveAfternoon;
    }

Console.WriteLine("_____________________________________________________________");

// Day 6 Morning 

currentDay = 6;
Console.WriteLine("Good morning! You had a restful weekend after a full first week at EFA.");
Console.WriteLine("This week, you will begin learning C#.");
Console.WriteLine("How do you spend your morning?");

Console.WriteLine("1. Practice your typing through SpeedCoder." );
Console.WriteLine("2. Get some extra sleep through type time.");
Console.WriteLine("3. Get ahead on the C# lesson for today.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");

daySixMorning:
string daySixMorning = Console.ReadLine();
int daySixMorningIntelligence = user.GetIntelligence();

{
    switch (daySixMorning)
    {
        case "1":
            Console.WriteLine("Your WPM is now around 30, but you managed to increase it around 3 WPM. Good job.");
            user.SetSpeed(1);
            Console.WriteLine($"Your typing speed is now {user.GetSpeed()}.");
            break;
        case "2":
            Console.WriteLine("You enjoyed the extra sleep but wake up groggy a minute before Zoom.");
            user.SetFocus(-1);
            Console.WriteLine($"Your Focus is now {user.GetFocus()}.");
            break;
        case "3":
            Console.WriteLine("You are hopelessly confused.");
            user.SetIntelligence(-2);
            Console.WriteLine($"Your focus skill is now {user.GetIntelligence()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto daySixMorning;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto daySixMorning;
    }
}

Console.WriteLine("_____________________________________________________________");

currentDay = 6;
Console.WriteLine("During your first C# lesson, you run into an error.");
Console.WriteLine("How do you go about fixing it?");

Console.WriteLine("1. Ask the instructor how to fix it." );
Console.WriteLine("2. Do a Google search.");
Console.WriteLine("3. Check Stats");
Console.WriteLine("_____________________________________________________________");

daySixAfternoon:
string daySixAfternoon = Console.ReadLine();
int daySixAfternoonIntelligence = user.GetIntelligence();

{
    switch (daySixAfternoon)
    {
        case "1":
            Console.WriteLine("Your instructor had to stop the lesson for everyone, but after 15 minutes you solve your problem.");
            break;
        case "2":
            Console.WriteLine("After a few minutes of digging, you find the solution to your problem! No more error!");
            user.SetIntelligence(1);
            Console.WriteLine($"Your Intelligence is now {user.GetIntelligence()}.");
            break;
        case "3":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto daySixAfternoon;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto daySixAfternoon;
    }
}

Console.WriteLine("_____________________________________________________________");

currentDay = 6;
Console.WriteLine("Congrats, you finished your first day of C# and your brain is extra tired!");
Console.WriteLine("What do you do now?");

Console.WriteLine("1. Cry." );
Console.WriteLine("2. Go to bed immediately.");
Console.WriteLine("3. Go back and review some of the material from the day.");
Console.WriteLine("4. Check Stats");
Console.WriteLine("_____________________________________________________________");

daySixNight:
string daySixNight = Console.ReadLine();
int daySixNightIntelligence = user.GetIntelligence();

{
    switch (daySixNight)
    {
        case "1":
            Console.WriteLine("You needed a good cry. C# is hard. You feel better now.");
            user.SetFocus(1);
            Console.WriteLine($"Your Focus skill is now {user.GetFocus()}.");
            break;
        case "2":
            Console.WriteLine("The extra sleep did you good. You wake up feeling refreshed and ready to learn more.");
            user.SetEndurance(1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            break;
        case "3":
            Console.WriteLine("You start to understand the syntax and structure of C#, however you have a headache from fatigue.");
            user.SetIntelligence(1);
            Console.WriteLine($"Your Focus skill is now {user.GetIntelligence()}.");
            user.SetEndurance(-1);
            Console.WriteLine($"Your Endurance is now {user.GetEndurance()}.");
            break;
        case "4":
            Console.WriteLine($"Your Endurance skill is {user.GetEndurance()}.");
            Console.WriteLine($"Your Intelligence skill is {user.GetIntelligence()}.");
            Console.WriteLine($"Your Typing Speed is {user.GetSpeed()}.");
            Console.WriteLine($"Your Focus skill is {user.GetFocus()}.");
            Console.WriteLine($"Your Current Grade is {user.GetGrade()}.");
            Console.WriteLine($"Enter a number between 1 and 3.");
            goto daySixNight;
        default:
            Console.WriteLine("Enter a number between 1 and 3.");
            goto daySixNight;
    }
}

Console.WriteLine("_____________________________________________________________");

// End of Game

Console.WriteLine("Congratulations, you've made it through six days of class! Let's check to see if you're passing.");

if (gradeLevel >= 90)
{
    Console.WriteLine("Congrats, you have an A in class!");
}

else if (gradeLevel>=80) {
    Console.WriteLine("You are passing with a B. Good job!");
}

else if (gradeLevel>=70){
    Console.WriteLine("You are barely passing with a C.");
}

else {
    Console.WriteLine("You are currently failing the class. Try to complete actions to bring your grade up.");
}

Console.WriteLine("_____________________________________________________________");

Console.WriteLine("We hope you enjoyed Eleven Fifty Trail!");

namespace storyVariables
{
    class Player
    {
        // constructor
        public Player(int endurance, int focus, int intelligence, int speed, int gradeLevel)
        {
            // setting user skills so we can increase them seprate from the original constructor
            userEndurance = endurance;
            userFocus = focus;
            userIntelligence = intelligence;
            userSpeed = speed;
            userGrade = gradeLevel;

        }
        // Methods
        public int GetEndurance()
        {
            return userEndurance;
        }

        public void SetEndurance(int enduranceChange)
        {
            userEndurance = userEndurance + enduranceChange;
        }

        public int GetFocus()
        {
            return userFocus;
        }

        public void SetFocus(int focusChange)
        {
            userFocus = userFocus + focusChange;
        }

        public int GetIntelligence()
        {
            return userIntelligence;
        }

        public void SetIntelligence(int IntelligenceChange)
        {
            userIntelligence = userIntelligence + IntelligenceChange;
        }

        public int GetSpeed()
        {
            return userSpeed;
        }

        public void SetSpeed(int speedChange)
        {
            userSpeed = userSpeed + speedChange;
        }

        public int GetGrade()
        {
            return userGrade;
        }

        public void SetGrade(int gradeChange)
        {
            userGrade = userGrade + gradeChange;
        }

        // Properties
        public int userEndurance { get; set; }
        public int userFocus { get; set; }
        public int userIntelligence { get; set; }
        public int userSpeed { get; set; }
        public int userGrade { get; set; }
    }
}
