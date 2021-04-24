namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int numberOfRaccoons = 3;
            int numberGoneHome = 2;
            int remainingNumberOfRaccoons = numberOfRaccoons - numberGoneHome;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int numberOfFlowers = 5;
            int numberOfBees = 3;
            int numberOfBeesLessThanFlowers = numberOfFlowers - numberOfBees;

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int numberEatingBreadcrumbs = 1;
            int numberEatingBreadcrumbsLater = 1;
            int numberEatingBreadcrumbsNow = numberEatingBreadcrumbs + numberEatingBreadcrumbsLater;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int numberOfOwlsOnFence = 3;
            int additionalNumberOfOwls = 2;
            int totalNumberOfOwlsOnFence = numberOfOwlsOnFence + additionalNumberOfOwls;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int numberOfBeaversWorking = 2;
            int numberOfBeaversSwimming = 1;
            int remainingNumberOfBeaversWorking = numberOfBeaversWorking - numberOfBeaversSwimming;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int numberOfToucansSitting = 2;
            int additionalNumberOfToucans = 1;
            int totalNumberOfToucans = numberOfToucansSitting + additionalNumberOfToucans;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int numberOfSquirrels = 4;
            int numberOfNuts = 2;
            int numberOfExtraSquirrels = numberOfSquirrels - numberOfNuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? // try again 
            */
            decimal valueOfQuarter = .25M;
            decimal valueOfDime = .10M;
            decimal valueOfNickel = .05M;
            int numberOfNickels = 2;
            decimal totalValueOfNickel = valueOfNickel * numberOfNickels;
            decimal totalValueOfChange = (decimal)(valueOfQuarter + valueOfDime + totalValueOfNickel);
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int numberOfMuffinsBrier = 18;
            int numberOfMuffinsMacadams = 20;
            int numberOfMuffinsFlannery = 17;
            int totalNumberOfMuffinsFirstGrade = numberOfMuffinsBrier + numberOfMuffinsMacadams + numberOfMuffinsFlannery;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double costOfYoyo = .24;
            double costOfWhistle = .14;
            double totalSpent = costOfYoyo + costOfWhistle;
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int numberOfLargeMarshmallows = 8;
            int numberOfMiniMarshmallows = 10;
            int totalNumberOfMarshmallows = numberOfLargeMarshmallows + numberOfMiniMarshmallows;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int inchesOfSnowHilt = 29;
            int inchesOfSnowSchool = 17;
            int extraInchesOfSnowHilt = inchesOfSnowHilt - inchesOfSnowSchool;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            double totalMoneyHilt = 10;
            double truckExpense = 3;
            double pencilCaseExpense = 2;
            double totalExpense = truckExpense + pencilCaseExpense; 
            double remainingMoneyHilt = totalMoneyHilt - totalExpense;
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int numberOfMarblesTotal = 16;
            int numberOfMarblesLost = 7;
            int remainingNumberOfMarbles = numberOfMarblesTotal - numberOfMarblesLost;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int numberOfSeashellsMegan = 19;
            int additionalNumberOfSeashells = 25 - numberOfSeashellsMegan;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int numberOfBalloonsTotal = 17;
            int numberOfRedBalloons = 8;
            int numberOfGreenBalloons = numberOfBalloonsTotal - numberOfRedBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int numberOfBooksOnShelf = 38;
            int additionalNumberOfBooksOnShelf = 10;
            int totalNumberOfBooksOnShelf = numberOfBooksOnShelf + additionalNumberOfBooksOnShelf;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int numberOfLegsPerBee = 6;
            int numberOfBeesHere = 8;
            int totalNumberOfLegsOfBeesHere = numberOfLegsPerBee * numberOfBeesHere;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double costOfIceCreamCone = .99;
            double numberOfIceCreamCone = 2;
            double totalCostOfIceCreamCone = costOfIceCreamCone * numberOfIceCreamCone;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int numberOfRocksNeeded = 125;
            int numberOfRocksHas = 64;
            int additionalNumberOfRocks = numberOfRocksNeeded - numberOfRocksHas;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int totalNumberOfMarblesHilt = 38;
            int numberOfMarblesLostHilt = 15;
            int remainingNumberOfMarblesHilt = totalNumberOfMarblesHilt - numberOfMarblesLostHilt;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int distanceOfConcert = 78;
            int distanceToGas = 32;
            int remainingDistanceToConcert = distanceOfConcert - distanceToGas;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int numberOfMinutesShovelingSnowInMorning = 90;
            int numberOfMinutesShovelingSnowinAfternoon = 45;
            int totalNumberOfMInutesShovelingSnow = numberOfMinutesShovelingSnowInMorning + numberOfMinutesShovelingSnowinAfternoon;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int numberOfHotDogsBought = 6;
            decimal costOfHotDogs = .50M;
            decimal totalCostOfHotDogs = numberOfHotDogsBought * costOfHotDogs;
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal moneyHilt = .50M;
            decimal costOfPencil = .07M;
            int maximumNumberOfPencils = (int)(moneyHilt / costOfPencil);
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int numberOfButterfliesTotal = 33;
            int numberOfButterfliesOrange = 20;
            int numberOfButterfliesRed = numberOfButterfliesTotal - numberOfButterfliesOrange;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal moneyGivenToClerk = 1.00M;
            decimal costOfCandy = .54M;
            decimal difference = moneyGivenToClerk - costOfCandy;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int numberOfTreesInBackyard = 13;
            int additionalNumberOfTreesPlanted = 12;
            int totalNumberOfTrees = numberOfTreesInBackyard + additionalNumberOfTreesPlanted;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int timeUntilMeetingInDays = 2;
            int timePerDayInHours = 24;
            int timeUntilMeetingInHours = timeUntilMeetingInDays * timePerDayInHours;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numberOfCousins = 4;
            int numberOfGumPiecesEach = 5;
            int totalNumberOfGumPiecesNeeded = numberOfCousins * numberOfGumPiecesEach;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal moneyDanHas = 3.00M;
            decimal costOfCandyBar = 1.00M;
            decimal remainingMoneyDanHas = moneyDanHas - costOfCandyBar;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numberOfBoatsInLake = 5;
            int numberOfPeoplePerBoat = 3;
            int totalNumberOfPeopleInBoats = numberOfBoatsInLake * numberOfPeoplePerBoat;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int totalNumberOfLegos = 380;
            int lostNumberOfLegos = 57;
            int remainingNumberOfLegos = totalNumberOfLegos - lostNumberOfLegos;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int numberOfMuffinsBaked = 35;
            int numberOfMuffinsNeeded = 83;
            int additionalNumberOfMuffinsRequired = numberOfMuffinsNeeded - numberOfMuffinsBaked;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int numberOfCrayonsWilly = 1400;
            int numberOfCrayonsLucy = 290;
            int differenceCrayons = numberOfCrayonsWilly - numberOfCrayonsLucy;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int numberOfStickersOnPage = 10;
            int numberOfPages = 22;
            int totalNumberOfStickers = numberOfStickersOnPage * numberOfPages;
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            double numberOfCupcakes = 96;
            double numberOfChildren = 8;
            double numberOfCupcakesPerChild = numberOfCupcakes / numberOfChildren;
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int numberOfCookies = 47;
            int numberOfCookiesPerJar = 6;
            int remainingCookiesOutsideJar = numberOfCookies % numberOfCookiesPerJar;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int numberOfCroissants = 59;
            int numberOfNeighbors = 8;
            int remainingNumberOfCroissants = numberOfCroissants % numberOfNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int numberOfCookiesPerTray = 12;
            int totalNumberOfCookies = 276;
            int numberOfTraysNeeded = totalNumberOfCookies / numberOfCookiesPerTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int numberOfPretzels = 480;
            int numberOfPretzelsPerServing = 12;
            int numberOfServings = numberOfPretzels / numberOfPretzelsPerServing;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int numberOfLemonCupcakes = 53;
            int numberOfLemonCupcakesPerBox = 3;
            int numberOfBoxesGiven = numberOfLemonCupcakes / numberOfLemonCupcakesPerBox;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int numberOfCarrotSticks = 74;
            int numberOfPeople = 12;
            int remainingCarrotSticks = numberOfCarrotSticks % numberOfPeople;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int numberOfTeddyBears = 98;
            int numberOfTeddyBearsPerShelf = 7;
            int numberOfShelvesFilled = numberOfTeddyBears / numberOfTeddyBearsPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int numberOfPicturesInAlbum = 20;
            int totalNumberOfPictures = 480;
            int numberOfAlbumsNeeded = totalNumberOfPictures / numberOfPicturesInAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int numberOfTradingCards = 94;
            int numberOfTradingCardsPerBox = 8;
            int numberOfBoxesFilled = numberOfTradingCards / numberOfTradingCardsPerBox;
            int remainingNumberOfCards = numberOfTradingCards % numberOfTradingCardsPerBox;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int numberOfBooks = 210;
            int numberOfShelves = 10;
            int numberOfBooksPerShelf = numberOfBooks / numberOfShelves;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            double numberOfCroissant = 17;
            double numberOfGuests = 7;
            double numberOfCroissantsPerGuest = numberOfCroissant / numberOfGuests;
            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */
            double timeTakenByBill = 2.15;
            double timeTakenByJill = 1.90;
            double timeTakenByBillPerHour = ((12 * 14) / timeTakenByBill);
            double timeTakenByJillPerHour = ((12 * 14) / timeTakenByJill);
            double timeTakenByBillAndJillPerHour = timeTakenByBillPerHour + timeTakenByJillPerHour;
            double totalTimeTakenByBillAndJill = (12 * 14 * 5) / timeTakenByBillAndJillPerHour;

            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            string firstName = "Grace";
            string lastName = "Hopper";
            string middleInitial = "B";
            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";
            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            int distanceBetweenNewYorkAndChicago = 800;
            int distanceTrainTraveled = 537;
            double percentageOfTripCompleted = (double)distanceTrainTraveled / distanceBetweenNewYorkAndChicago;
            int wholeNumberPercentageOfTripCompleted = (int)(percentageOfTripCompleted * 100); 


        }
    }
}
