using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {
		Intro_0, Intro_N, Intro_N2, Intro_Y, Poof, Hibernate, Nothing, Fly, Grass, 
		Milkweed, Nectar, Mexico, Milkweed_1, Solution, Farm, Road, House
	};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.Intro_0;
	}
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.Intro_0)		{Intro_0();}
		else if (myState == States.Intro_N)	 	{Intro_N();}
		else if (myState == States.Intro_N2)	{Intro_N2();}
		else if (myState == States.Intro_Y) 	{Intro_Y();}
		else if (myState == States.Poof)    	{Poof();}
		else if (myState == States.Hibernate)	{Hibernate();}
		else if (myState == States.Nothing)     {Nothing();}
		else if (myState == States.Fly)    		{Fly();}	
		else if (myState == States.Grass)    	{Grass();}
		else if (myState == States.Milkweed)    {Milkweed();}		
		else if (myState == States.Nectar)    	{Nectar();}
		else if (myState == States.Mexico)    	{Mexico();}
		else if (myState == States.Milkweed_1)  {Milkweed_1();}		
		else if (myState == States.Solution)  	{Solution();}
		else if (myState == States.Farm)   		{Farm();}
		else if (myState == States.Road)   		{Road();}
		else if (myState == States.House)   	{House();}
	}

	void Intro_0 () {
		text.text =  "MONARCH BUTTERFLY RESCUE \n\n"+
					" · · · – – – · · ·            · · · – – – · · ·\n\n" +
					"Monarch Butterflies are in danger! \n\n" +
					"1,000 million Monarch Butterflies \n" + 
					"were counted 25 years ago.\n\n" +
					"Less than 60 million were counted in 2015.\n\n" +
					"Will you help? \n\n"+
					"Press Y for Yes.  Press N for No." ;
		if (Input.GetKeyDown(KeyCode.N)) 		{myState = States.Intro_N;}
		else if (Input.GetKeyDown(KeyCode.Y))	{myState = States.Intro_Y;}
	}
	void Intro_N () {
		text.text = "YOU'RE KIDDING ME! \n\n" +
					"It’s easy, fun, and important \n" +
					"that you hep. \n\n" +
					"Please help \n\n\n" +
					"Press Y for Yes.  Press N for No." ;		
		if (Input.GetKeyDown(KeyCode.N)) 		{myState = States.Intro_N2;}
		else if (Input.GetKeyDown(KeyCode.Y)) 	{myState = States.Intro_Y;}
	}
	void Intro_N2 () {
		text.text = "BORING! \n\n" +
					"You AND the Monarch Butterflies lose! \n\n\n" +
					"This game is over. \n\n\n" +
					"Press P to Play a new game." ;
		if (Input.GetKeyDown(KeyCode.P)) 		{myState = States.Intro_0;}
	}
	void Intro_Y () {
	text.text = "EXCELLENT! \n\n\n" +
				"To save the Monarch Butterflies. \n" +
				"You have to think like a Monarch Butterfly.\n\n" + 
				"Press any key to continue" ;
		if (Input.anyKeyDown) 					{myState = States.Poof;}
	}
	void Poof () {
		text.text = "POOF!! \n\n" +
				"You have changed .... \n" +
				"            changed into an adult .... \n" +
				"                      an adult Monarch Butterfly!! \n\n" +
				"You look GREAT!  Nice wings.  Such a delicate mouth. \n\n" +
				
				"It is August.  Summer is ending in Ohio.\n" +
				"The days are warm, but the nights are cold. \n\n" +
				"Press H to Hibernate. \n" +
				"Press F to Fly South. \n" +
				"Press N to Do Nothing." ;
		if (Input.GetKeyDown(KeyCode.N)) 		{myState = States.Nothing;}
		else if (Input.GetKeyDown(KeyCode.F)) 	{myState = States.Fly;}
		else if (Input.GetKeyDown(KeyCode.H)) 	{myState = States.Hibernate;}
	} 	
	void Nothing () {
		text.text = "Do nothing?  Spend the rest of the summer in Ohio?! \n\n" +
					"Butterfly, the cold nights mean winter is coming. \n\n" +
					"You will freeze.  \n" +
					"You better do something before you turn into a Butterfly-icicle. \n\n\n" +
					"Press H to Hibernate. \n" +
					"Press F to Fly South. \n" ;
		if 		(Input.GetKeyDown(KeyCode.F)) 	{myState = States.Fly;}
		else if (Input.GetKeyDown(KeyCode.H)) 	{myState = States.Hibernate;}
	}
	void Hibernate () {
		text.text = "Monarch Butterflies do not hibernate. \n\n" +
					"Bears, bats, snakes, bees, and other animals do. \n\n\n" +
					"Press N to Do Nothing." +
					"Press F to Fly South." ;
		if 		(Input.GetKeyDown(KeyCode.F)) 	{myState = States.Fly;}
		else if (Input.GetKeyDown(KeyCode.N)) 	{myState = States.Nothing;}
	}
	void Fly() {
		text.text = "YIPPEE! \n" +
					"YOU'RE GOING TO MEXICO!! \n\n\n" +
					"Better eat up! \n" +
					"You need A LOT of energy. You have 2,000 miles to fly to the \n" +
					"Monarch Butterfly Biosphere Reserve near Mexico City. \n\n" +
					"What do you like to eat? \n\n\n" +
					"Press G for Grass. \n"+
					"Press M for Milkweed leaves. \n"+
					"Press N for Nectar from flowers." ;
		if (Input.GetKeyDown(KeyCode.G)) 		{myState = States.Grass;}
		else if (Input.GetKeyDown(KeyCode.M)) 	{myState = States.Milkweed;}
		else if (Input.GetKeyDown(KeyCode.N)) 	{myState = States.Nectar;}
	}
	void Grass () {
		text.text = "No.  Monarch Butterflies do not eat grass. \n\n"+
					"Grass lawns are a green desert for \n" +
					"butterflies, bees,and birds.  \n" +
					"The clover in a lawn is a good choice for us creatures,\n" +
					"but sadly most people consider it a weed and remove it. \n\n"+
					"Press M for Milkweed leaves. \n" +
					"Press N for Nectar from flowers." ;
		if (Input.GetKeyDown(KeyCode.M)) 		{myState = States.Milkweed;}
		else if (Input.GetKeyDown(KeyCode.N)) 	{myState = States.Nectar;}
	}
	void Milkweed () {
		text.text = "No.  Monarch Butterflies ADULTS do not eat \n" +
					"Milkweed LEAVES. Our caterpillar babies DO. \n\n" +
					"You can tell by comparing the delicate straw-like mouths \n" +
					"of adult butterflies to the massive munching mouthparts \n" + 
					"of caterpillars. \n\n" +
					"Try again.  I’m very hungry. \n\n\n" +
				
					"Press G for Grass. \n"+
					"Press N for Nectar from flowers." ;
		if (Input.GetKeyDown(KeyCode.G)) 		{myState = States.Grass;}
		else if (Input.GetKeyDown(KeyCode.N)) 	{myState = States.Nectar;}
	}
	void Nectar () {
		text.text = "YES! \n\n\n" +
					"Adult Monarch Butterflies live on a diet of liquid nectar \n" +
					"from a wide range of plants, including Milkweed nectar. \n\n" +
					"Monarch Butterflies feed on flower nectar fattening up the summer \n" +
					"BEFORE and DURING the entire 2,000 mile trip to Mexico. \n\n"+
					"Better have plenty of flowering nectar plants when we pass by! \n\n\n" +
					"Press any key to continue" ;
		if (Input.anyKeyDown) 					{myState = States.Mexico;}
	}
	void Mexico () {
		text.text = "FINALLY! MEXICO! \n\n\n" +
					"Monarch Butterflies from 100 million hectares across \n" +
					"U.S.A. and Canada meet up on just 20 hectares in Mexico. \n\n" +
					"Thank you Mexico for protecting this important place! \n\n" +
					"The Oyemel fir trees, mild temperatures, and wet climate \n"+
					"make Mexico lovely in the winter for butterflies. \n\n" +
					"Press any key to continue" ;
		if (Input.anyKeyDown) 					{myState = States.Milkweed_1;}
	}
	void Milkweed_1() {
		text.text = "TIME TO MIGRATE NORTH! \n\n\n" +
					"As winter ends, Monarch Butterflies return back north.\n" +
					"It may take as many as 5 generations to complete the \n" +
					"roundtrip each year. \n\n" +
					"You MUST find Milkweed plants to lay the eggs \n" +
					"of your next generation of butterflies. \n\n" +
					"Where do you want to look for Milkweed plants?\n\n\n" +
					"Press F for at Farms. \n"+
					"Press R for along Roads. \n"+
					"Press H for at Houses." ;
			if 		(Input.GetKeyDown(KeyCode.F)) 	{myState = States.Farm;}
			else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.Road;}
			else if (Input.GetKeyDown(KeyCode.H)) 	{myState = States.House;}
	}
	void Solution() {
		text.text = "PLANT MORE MILKWEED! \n\n" +
					"USE LESS PESTICIDE WHERE MILKWEEDS GROW! \n\n\n"+
					"Now that you can better think like a Monarch Butterfly, \n" +
					"you can better act to help them.\n\n"+
					"To REALLY help, and make your important places a Monarch Butterfly\n" +
					"way station, contact groups such as Monarch Watch. \n\n" +
					"You can find them at the website, \n" +
					"http://www.monarchwatch.org/blog/ \n\n" +
					"Want to Play again?  Press P";
		if 		(Input.GetKeyDown(KeyCode.P)) 	{myState = States.Intro_0;}
	}
	void Farm() {
		text.text = "Farms are great places for butterflies! \n\n" +
					"However, large farms that use the pesticide Roundup \n"+
					"to kill weeds also kill Milkweed. \n" +
					"Of the 70% of the Milkweed lost in recent years,\n" + 
					"Some 100 million hectares, has occurred at farms. \n\n" +
					
					"What do you think is a solution? \n\n" +
					"Press S for two ideas. " ;
		if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.Solution;}
	}
	void Road() {
		text.text = "Mile after mile of roads cross the country! \n\n" + 
					"Some roads are right along the Monarch Butterfly  \n" + 
					"travel route, such as Interstate Highway, which cross 1,400 miles \n" +
					"from Texas all the way to Minnesota! \n\n" +
					"Unfortunately, road maintenance includes spraying pesticides \n" +
					"to control weeds, and kills the sensitive Milkweed plant. \n\n" +
					"What do you think is a solution? \n\n" +
					"Press S for two ideas. " ;
		if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.Solution;}
	}
		void House() {
			text.text = "There are 100 million houses in the U.S.A. \n" +
						"Each one has some land that Monarch Butterflies \n" +
						"could visit. \n\n" + 
						"Sad to say, few homeowners have planted Milkweeds \n" + 
						"around their house. The same is true of office buildings, \n" +
						"shopping malls, and houses of worhip. \n\n" +
						"What do you think is a solution? \n\n" +
						"Press S for two ideas. " ;
		if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.Solution;}
	}
}