using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       public Text Char3name;
       public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       public GameObject ArtChar1b;
       public GameObject ArtChar1c;
	   public GameObject ArtChar1d;
	   public GameObject ArtChar1e;
	   public GameObject ArtChar2a;
        public GameObject ArtChar2b;
		public GameObject ArtChar2c;
		public GameObject ArtChar2d;
		public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		ArtChar1d.SetActive(false);
		ArtChar1e.SetActive(false);
		ArtChar2a.SetActive(false);
		ArtChar2b.SetActive(false);
		ArtChar2c.SetActive(false);
		ArtChar2d.SetActive(false);
		ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

     // Find the gameHandler:
     // gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       next();
                }
        }
   }

//Story Units! This is the main story function. Players hit [NEXT] to progress to the next primeInt:
public void next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               ArtChar1d.SetActive(true);
                ArtChar2a.SetActive(true);
				DialogueDisplay.SetActive(true);
                Char1name.text = "Fish";
                Char1speech.text = "Hey look! A dolphin!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar2a.SetActive(false);
				ArtChar2d.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dolphin";
                Char2speech.text = "Yo! Watch this!";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
		
		       else if (primeInt ==4){
                ArtChar2a.SetActive(false);
				ArtChar2d.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "NARRATOR";
                Char3speech.text = "*The dolphin shows you their epic tricks*";
                //gameHandler.AddPlayerStat(1);
        }
		
       else if (primeInt == 5){
                ArtChar1d.SetActive(false);
				ArtChar1b.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "WOOooow. That’s really neat!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 6){
                ArtChar2d.SetActive(false);
				ArtChar2a.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dolphin";
                Char2speech.text = "You like my moves?";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 7){
                Char1name.text = "Fish";
                Char1speech.text = "Sure! You should be the entertainment at my party!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==8){
                ArtChar2a.SetActive(false);
				ArtChar2b.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dolphin";
                Char2speech.text = "Entertainment?";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "Fish";
                Char1speech.text = "Yeah, do your little dances at my party! I’m sure everyone will love it!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
               
		 }
       else if (primeInt == 10){
                ArtChar2b.SetActive(false);
				ArtChar2c.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dolphin";
                Char2speech.text = "Y’know I could teach you these tricks if you’d like…";
				Char3name.text = "";
                Char3speech.text = "";

			   // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
             ArtChar1e.SetActive(false);
			 ArtChar1b.SetActive(true);
			 Char1name.text = "Fish";
                Char1speech.text = "I really did admire your moves!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 101){
               ArtChar2c.SetActive(false);
				ArtChar2b.SetActive(true);
			  Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dolphin";
                Char2speech.text = "It didn’t sound like you did…";
				Char3name.text = "";
                Char3speech.text = "";
        }
	   else if (primeInt == 102){
               ArtChar1b.SetActive(false);
				ArtChar1a.SetActive(true);
			   ArtChar2b.SetActive(false);
			   ArtChar2a.SetActive(true);
			 Char1name.text = "Fish";
                Char1speech.text = " Oh but I did! I’ve never seen anything as majestic as your performance!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
	   else if (primeInt == 103){
               ArtChar2a.SetActive(false);
			   ArtChar2b.SetActive(true);
			   Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dolphin";
                Char2speech.text = "Wait! I uh…I wouldn’t mind going to your party…";
				Char3name.text = "";
                Char3speech.text = "";
        }
	   else if (primeInt == 104){
                ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
				ArtChar2b.SetActive(false);
			   ArtChar2a.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Really!? Neat-o! See ya at my party then!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
	   else if (primeInt == 105){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dolphin";
                Char2speech.text = "Goobye, Fish.";
				Char3name.text = "";
                Char3speech.text = "";
        }
	   
	   else if (primeInt == 106){
                ArtChar2a.SetActive(false);
				Char1name.text = "Fish";
                Char1speech.text = "Where to next? The reef or the sea floor!?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
				NextScene2Button.SetActive(true);
        }

        else if (primeInt == 200){
                Char1name.text = "Fish";
                Char1speech.text = "OI! Why did you hit me???";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dolphin";
                Char2speech.text = " because I feel like it.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "NARRATOR";
                Char3speech.text = "*The dolphin continues to bully Fish.*";
        }
       else if (primeInt == 203){
                Char1name.text = "Fish";
                Char1speech.text = "Hey! Stop that!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
	   else if (primeInt == 204){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dolphin";
                Char2speech.text = "I don’t think I will";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 205){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "NARRATOR";
                Char3speech.text = "*The dolphin punches Fish.*";
        }
	   else if (primeInt == 206){
                Char1name.text = "Fish";
                Char1speech.text = "That hurts!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
	   
	   else if (primeInt == 207){
                ArtChar1e.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "*The Dolphin tosses fish out of water.*";
				Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(true);
                allowSpace = false;
                
        }

       else if (primeInt == 208){
                Char1name.text = "";
                Char1speech.text = "";
				nextButton.SetActive(false);
				//NextScene3Button.SetActive(true);
		SceneManager.LoadScene("End_Lose4");
                // Char2name.text = "";
                // Char2speech.text = "";
        }
      //Please do NOT delete this MOST HOLY bracket that ends the next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                ArtChar1b.SetActive(false);
				ArtChar1e.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Darn, that’s just too bad.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                ArtChar1b.SetActive(false);
				ArtChar1e.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "NARRATOR";
                Char3speech.text = "*The dolphin smacks Fish. ";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene5a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene5b");
        }
		public void SceneChange3(){
                SceneManager.LoadScene("End_Lose3");
        }
}
