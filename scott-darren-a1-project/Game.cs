//Background Functions
//Stored Variables
int playerChoice;
String heroName;


//Game Introduction
Console.WriteLine("Driftwood Darren presents:\nTHE BHEUR TOWN!\n\n\n");
Console.Write("A voice calls out to you through the snowy streets:\n\"AH! Ye must be my new adventurer eh? The name is Torgaa Strakeln! Pleasure t'meet ye." +
    "Tell me, what be yer name hero?\"\nEnter your name: ");
heroName = Console.ReadLine();
Console.WriteLine($"\n\"Well met {heroName}! Quite the pleasure t'meet ya!");


//Context For 1st Player Decision
Console.WriteLine($"Well {heroName} if ye follow me I can give ye a tour o' the tow-\"\n\n\"AAAAAGH!\"\n\n" +
    "The sound of screams cut through the air! Rushing over to the noise you spot the source: The village is under attack! " +
    "Charging from the nearby forest the attackers reveal themselves: FROST GNOLLS! Hyena warriors who follow the Demon god of hunger! " +
    "These gnolls appear to a scouting force, testing the villages capabilities. Their force consists of\n\nAggressive Front Line Troops\n" +
    "A Ranged Supporting Force\nA Small Flanking Party\n");


//The 1st Player Decision
Console.Write("You must decide how to repel the gnoll attack!\n1: Charge the Frontline Troops\n2: Provide Fire Support from Range\n3: Ambush the Flanking Force\n" +
    "Please enter your decision: ");
playerChoice = int.Parse(Console.ReadLine());


//Player Results
//Path 1 (Fight the Gnolls Head On)
if (playerChoice == 1)
{
    Console.Write("\nYou charge headlong into the gnoll advance! Drawing your sword you make contact with the warband! You are flurry of flashing steel and silver as gnolls are cut down at your feet! " +
        "As the fury of clashing blades become a whirlwind around you; an opportunity for a killing blow presents itself. Accompanying the warband is a pack of wolves. They look weak.\n\n" +
        "1: Finish off the wolves\n2: Focus on the Gnoll Warriors\nPlease enter your decision: ");
    playerChoice = int.Parse(Console.ReadLine());
}

//Path 2 (Provide Ranged Support)
else if (playerChoice == 2)
{
    Console.Write("\nDrawing your bow, you loose volley after volley of arrow at the both the gnoll charge and their support. Felling warrior after warrior with deadly accuracy. " +
        "Now suffering from heavy losses, the gnolls begin to rout, fleeing back to the woods whence they came. " +
        "Victory has been acheived, but at a steep cost as scores of villagers lay dead in the snow, dying to defend their land.");
}
//Path 3 (Attack the Flanking Force)
else if (playerChoice == 3)
{
    Console.Write("\nLying in wait in the snow, you wait for the flanking gnolls to unknowingly rush into your trap. In an instant, you surprise the gnolls, catching them flat footed. " +
        "Before they can even react you have already disposed of the key leadership and special troops, forcing the disorganized gnolls to retreat. " +
        "Seeing the flanking force capitulate, the main charge has been stalled and the gnolls begin to rout back to the forst. Victory has been acheived.");
}
//"Path 4" (Indecision) 
else
{
    Console.Write("\nYou are paralyzed with indecision, unable to pick a course of action. As you stand helplessly in the snow, the Gnolls crash through the town, killing every villager they can find until none are left alive. " +
        "You are not spared long enough to regret your inaction: one swift swipe from a shortsword removes your head from your shoulders, marking your end...\n\nYOU HAVE DIED...\n\n\n");
}