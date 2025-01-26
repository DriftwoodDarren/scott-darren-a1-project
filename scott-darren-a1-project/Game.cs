//Background Functions
//Stored Variables
int playerChoice;
String heroName;


//Game Introduction
Console.WriteLine("Driftwood Darren presents:\nTHE BHEUR TOWN!\n\n\n");
Console.Write("A voice calls out to you through the snowy streets:\n\"AH! Ye must be my new adventurer eh? The name is Torgaa Strakkeln! Pleasure t'meet ye. " +
    "Tell me, what be yer name hero?\"\nEnter your name: ");
heroName = Console.ReadLine();
Console.WriteLine($"\n\"Well met {heroName}! Quite the pleasure t'meet ya!");


//1st Player Decision
Console.WriteLine($"Well {heroName} if ye follow me I can give ye a tour o' the tow-\"\n\n\"AAAAAGH!\"\n\n" +
    "The sound of screams cut through the air! Rushing over to the noise you spot the source: The village is under attack! " +
    "Charging from the nearby forest the attackers reveal themselves: FROST GNOLLS! Hyena warriors who follow the Demon god of hunger! " +
    "These gnolls appear to a scouting force, testing the villages capabilities. Their force consists of\n\nAggressive Front Line Troops\n" +
    "A Ranged Supporting Force\nA Small Flanking Party\n");
Console.Write("You must decide how to repel the gnoll attack!\n1: Charge the Frontline Troops\n2: Provide Fire Support from Range\n3: Ambush the Flanking Force\n" +
    "Please enter your decision: ");
playerChoice = int.Parse(Console.ReadLine());


//Path 1 (Fight the Gnolls Head On)
if (playerChoice == 1)
{
    Console.Write("\nYou charge headlong into the gnoll advance! Drawing your sword you make contact with the warband! You are flurry of flashing steel and silver as gnolls are cut down at your feet! " +
        "As the fury of clashing blades become a whirlwind around you; an opportunity for a killing blow presents itself. Accompanying the warband is a pack of wolves. They look weak.\n\n" +
        "1: Finish off the wolves\n2: Focus on the Gnoll Warriors\nPlease enter your decision: ");
    playerChoice = int.Parse(Console.ReadLine());

    //2nd Player Decision 
    //Path 1-1 (Finish off the Wolves)
    if (playerChoice == 1)
    {
        Console.Write("\nTargeting the wolves, they prove to be quite weak. You are able to quickly dispatch swathes of wolves.\n\nHowever, honing in one one set of targets has proven to be a mistake! " +
            "Too busy chopping away at the ferocious wolves, you fail to notice the gnoll warrior who has targeted YOU! With a swift blow, you are hit from behind and fall to the ground. " +
            "Wasting no time the gnoll delivers a final fatal blow, marking your end in the snow...\n\nYOU HAVE DIED...\n\n\n");
    }
    //Path 1-2 (Focus on the Gnoll Warriors)
    else if (playerChoice == 2)
    {
        Console.Write("\nFocusing on the gnoll warriors they prove to be formidable foes, but nothing that can stand against your blade. You cut down warrior after warrior, all the while the wolves attempt " +
            "to stop you They are only able to inflict minor wounds as you slaughter their masters one by one. Seeing their masters helplessly cut down, the wolves begin to flee for their lives back into the forest. " +
            "\n\nWith the main body of the attack cut down, the remainder of the gnolls are routed, following behind the wolves back from whence they came.\n\nVictory has been Acheived!");

        //3rd Player Decision
        Console.Write("\n\nThe scouting force has retreated, but the gnolls will return. The remaining villagers are looking for you for answers on how to continue. With your wounds sustained from fighting you figure catching the gnolls unprepared at their home base is out of the question. After deliberating for a while you are left with 2 options: " +
            "\n1. Stay Behind and Evacuate the village\n2. Prepare a deliberate defense of the village\nPlease enter your decision: ");
        playerChoice = int.Parse(Console.ReadLine());

        //Path 1-2-1 (Evacuate the Village)
        if (playerChoice == 1)
        {
            Console.WriteLine("\nRounding up all the survivors of the attack, you load all supplies that you can and saddle all the horses you can find. Many are saddened having to leave their homes behind. " +
                "With all the villagers prepared to leave, the march to the Southern roads begins. The exodus has left the village of Watersreach utterly abadonded, but the villagers are safe. " +
                "Staying behind to buy time for the villagers, when the next morning's sun comes up you meet the gnoll advance head on. You carve a path through the warriors, however you are eventually cut down. " +
                "Though you have fallen, meeting your end in such glorious fashion, your sacrifice has bought time for the villagers to escape safely...\n\nQuest Accomplished....At a Cost...\n\nThank you for playing!\n\n\n");
        }
        //Path 1-2-2 (Defend the Village)
        else if (playerChoice == 3)
        {
            Console.WriteLine("\nPreparing a defense of the village you spend the day gathering materials needed to fashion hasty defences and improvised weapons. Most of the day is spent toiling away in preparation for the second wave of gnolls. " +
                "At first light the following morning, the warband crests a nearby hill, their numbers silohuetted against the rising sun. They number in the hundreds, this will be an uphill battle you think to yourself. " +
                $"You steel yourself as the gnolls begind their charge, a wave of teeth and claws about to come crashing down on your positions. The battle has begun...\n\n{heroName}'s journey will continue in Part 2: The Gnoll Caves!\n\nThank you for playing!\n\n\n");
        }
        //"Path 1-2-3" (Indecision) 
        else
        {
            Console.WriteLine("\nPlagued with indecision the town cannot come to an agreement. Still stewing when the next wave of gnolls crested the hill the next day, the village was outmatched " +
                "and any that remained after the first wave could not survive the second. Even if you had survived, your mission to protect the villagers has failed...\n\nQUEST FAILED\n\nThank you for playing!\n\n\n");
        }
    }
    //"Path 1-3" (Indecision)
    else
    {
        Console.Write("\nYou sit unable to decide which to target. Your hesitation has cost you, as both the warriors and the wolves take advantage of this and rush you. You are overwhelmed by the number of opponents " +
            "and they sink teeth, claw and steel into your flesh. You are left bleeding in the snow as the world fades away...\n\nYOU HAVE DIED...\n\n\n");
    }
}


//Path 2 (Provide Ranged Support)
else if (playerChoice == 2)
{
    Console.WriteLine("\nDrawing your bow, you loose volley after volley of arrow at the both the gnoll charge and their support. Felling warrior after warrior with deadly accuracy. " +
        "Now suffering from heavy losses, the gnolls begin to rout, fleeing back to the woods whence they came. " +
        "Victory has been acheived, but at a steep cost as scores of villagers lay dead in the snow, dying to defend their land.");

    //2nd Player Decision 
    Console.Write("\nThe scouting force has retreated, but the gnolls will return. The remaining villagers are looking for you for answers on how to continue. " +
        "\nWith a large population of the village dead, defending from a large attack is out of the question. After deliberating for a while you are left with 2 options: " +
        "\n1. Evacuate the village and flee South\n2. Venture to the gnoll base and attack them while they're unprepared\nPlease enter your decision: ");
    playerChoice = int.Parse(Console.ReadLine());

    //Path 2-1 (Evacuate the Village)
    if (playerChoice == 1)
    {
        Console.WriteLine("\nRounding up all the survivors of the attack, you load all supplies that you can and saddle all the horses you can find. Many are saddened having to leave their homes behind. " +
            "With all the villagers prepared to leave, the march to the Southern roads begins. The exodus has left the village of Watersreach utterly abadonded, but the villagers are safe.\n\nQuest Accomplished\n\nThank you for playing!\n\n\n");
    }
    //Path 2-2 (Attack Gnoll Base)
    else if (playerChoice == 2)
    {
        Console.WriteLine("\nAfter careful consideration you have decided to travel to the gnoll base and strike before they are prepared. Gathering your supplies you prepare to follow the gnoll tracks back to their territory." +
            $"The trek will take you through the wilderness and will be treachorous. Setting off, you steel your mind and prepare for the task ahead...\n\n{heroName}'s journey shall continue in part 2: \'THE GNOLL CAVES!\'");
    }
    //"Path 2-3" (Indecision) 
    else
    {
        Console.WriteLine("\nPlagued with indecision the town cannot come to an agreement. Still stewing when the next wave of gnolls crested the hill the next day, the village was outmatched " +
            "and any that remained after the first wave could not survive the second. Even if you had survived, your mission to protect the villagers has failed...\n\nQUEST FAILED\n\nThank you for playing!\n\n\n");
    }
}


//Path 3 (Attack the Flanking Force)
else if (playerChoice == 3)
{
    Console.WriteLine("\nLying in wait in the snow, you wait for the flanking gnolls to unknowingly rush into your trap. In an instant, you surprise the gnolls, catching them flat footed. " +
        "Before they can even react you have already disposed of the key leadership and special troops, forcing the disorganized gnolls to retreat. " +
        "Seeing the flanking force capitulate, the main charge has been stalled and the gnolls begin to rout back to the forest. Victory has been acheived.");

    //2nd Player Decision
    Console.Write("\nThe scouting force has retreated, but the gnolls will return. The remaining villagers are looking for you for answers on how to continue. After deliberating for a while you are left with 3 options: " +
        "\n1. Evacuate the village and flee South\n2. Venture to the gnoll base and attack them while they're unprepared\n3. Prepare a deliberate defense of the village\nPlease enter your decision: ");
    playerChoice = int.Parse(Console.ReadLine());

    //Path 3-1 (Evacuate the Village)
    if (playerChoice == 1)
    {
        Console.WriteLine("\nRounding up all the survivors of the attack, you load all supplies that you can and saddle all the horses you can find. Many are saddened having to leave their homes behind. " +
            "With all the villagers prepared to leave, the march to the Southern roads begins. The exodus has left the village of Watersreach utterly abadonded, but the villagers are safe.\n\nQuest Accomplished\n\nThank you for playing!\n\n\n");
    }
    //Path 3-2 (Attack Gnoll Base)
    else if (playerChoice == 2)
    {
        Console.WriteLine("\nAfter careful consideration you have decided to travel to the gnoll base and strike before they are prepared. Gathering your supplies you prepare to follow the gnoll tracks back to their territory." +
            $"The trek will take you through the wilderness and will be treachorous. Setting off, you steel your mind and prepare for the task ahead...\n\n{heroName}'s journey shall continue in part 2: \'THE GNOLL CAVES!\'");
    }
    //Path 3-3 (Defend the Village)
    else if (playerChoice == 3)
    {
        Console.WriteLine("\nPreparing a defense of the village you spend the day gathering materials needed to fashion hasty defences and improvised weapons. Most of the day is spent toiling away in preparation for the second wave of gnolls. " +
            "At first light the following morning, the warband crests a nearby hill, their numbers silohuetted against the rising sun. They number in the hundreds, this will be an uphill battle you think to yourself. " +
            $"You steel yourself as the gnolls begind their charge, a wave of teeth and claws about to come crashing down on your positions. The battle has begun...\n\n{heroName}'s journey will continue in Part 2: The Gnoll Caves!\n\nThank you for playing!\n\n\n");
    }
    //"Path 3-4" (Indecision) 
    else
    {
        Console.WriteLine("\nPlagued with indecision the town cannot come to an agreement. Still stewing when the next wave of gnolls crested the hill the next day, the village was outmatched " +
            "and any that remained after the first wave could not survive the second. Even if you had survived, your mission to protect the villagers has failed...\n\nQUEST FAILED\n\nThank you for playing!\n\n\n");
    }
}

//"Path 4" (Indecision) 
else
{
    Console.Write("\nYou are paralyzed with indecision, unable to pick a course of action. As you stand helplessly in the snow, the Gnolls crash through the town, killing every villager they can find until none are left alive. " +
        "You are not spared long enough to regret your inaction: one swift swipe from a shortsword removes your head from your shoulders, marking your end...\n\nYOU HAVE DIED...\n\n\n");
}