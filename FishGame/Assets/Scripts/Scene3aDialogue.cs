using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour {
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
		
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;
		public static bool sharkFriend = false;
		public static int friends;


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
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice2a.SetActive(false);
        Choice2b.SetActive(false);
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
	        DialogueDisplay.SetActive(true);
        }
        else if (primeInt == 2){
               ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "NARRATOR";
                Char1speech.text = "*You approach the cave...  It’s quiet...*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
		       ArtChar1a.SetActive(false);
		       ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "ANYONE WANNA COME TO MY PARTY?!";
	            Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "NARRATOR";
                Char1speech.text = "*Fish’s voice echoes throughout the cave.*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "NARRATOR";
                Char1speech.text = "*The echoes come to a stop. No reply.*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
		       ArtChar1d.SetActive(false);
		       ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Guess nobody’s home.  Where shall we go next?";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "A deep, powerful voice";
                Char3speech.text = "A PARTY?";
        }
		else if (primeInt ==8){
		       ArtChar2a.SetActive(true);
                Char1name.text = "NARRATOR";
                Char1speech.text = "*oH fUCc it's a  S H A R K*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Yeah!  It’s gonna be a reeeal shindig!  You in?";
				Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER CHOICE #1A
       else if (primeInt == 100){
		        Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
				Choice2a.SetActive(true);
                Choice2b.SetActive(true);
                allowSpace = true;
        }
// ENCOUNTER AFTER CHOICE #1B
       else if (primeInt == 200){
		        ArtChar2a.SetActive(false);
		        ArtChar2b.SetActive(true);
		        Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Shark";
                Char3speech.text = "YES THAT IS TRUE LITTLE ONE. I VERY MUCH ENJOY A GOOD OLD FASHIONED HOEDOWN. I WILL MOST DEFINITELY BE THERE FOR THE OCCASION.";
        }
		       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "See?  What did I tell you?  We will see you there Mr. Shark!";
				Char3name.text = "";
                Char3speech.text = "";
        }
		       else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Shark";
                Char3speech.text = "AND I YOU.";
				sharkFriend = true;
				friends = friends+1;
        }

       else if (primeInt == 203){
		        ArtChar1a.SetActive(false);
		        ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Alrighty!  Where to next? There's a shipwreck and the harbor!";
				Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
				NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
                allowSpace = false;
        }
// ENCOUNTER AFTER CHOICE #2A
else if (primeInt == 300){
	           ArtChar2a.SetActive(false);
		       ArtChar2b.SetActive(true);
		        Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Shark";
                Char3speech.text = "THAT IS QUITE ALL RIGHT LITTLE ONE. I WILL MOST DEFINITELY BE THERE FOR THE OCCASION.";
        }
		       else if (primeInt == 301){
				ArtChar1e.SetActive(false);
		        ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "See?  What did I tell you?  We will see you there Mr. Shark!";
				Char3name.text = "";
                Char3speech.text = "";
        }
		       else if (primeInt == 302){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Shark";
                Char3speech.text = "AND I YOU.";
				sharkFriend = true;
				friends = friends+1;
        }

               else if (primeInt == 303){
			    ArtChar1a.SetActive(false);
		        ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Alrighty!  Where to next? There's a shipwreck and the harbor!";
				Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
				NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
                allowSpace = false;
        }
// ENCOUNTER AFTER CHOICE #2B
else if (primeInt == 400){
	            ArtChar2a.SetActive(false);
		        ArtChar2b.SetActive(true);
		        Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Shark";
                Char3speech.text = "YES THAT IS TRUE LITTLE ONE. I VERY MUCH ENJOY A GOOD OLD FASHIONED HOEDOWN. I WILL MOST DEFINITELY BE THERE FOR THE OCCASION.";
        }
		       else if (primeInt == 401){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "See?  What did I tell you?  We will see you there Mr. Shark!";
				Char3name.text = "";
                Char3speech.text = "";
        }
		       else if (primeInt == 402){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Shark";
                Char3speech.text = "AND I YOU.";
				sharkFriend = true;
				friends = friends+1;
        }

               else if (primeInt == 403){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Alrighty!  Where to next? There's a shipwreck and the harbor!";
				Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
				NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
                allowSpace = false;
        }

      //Please do NOT delete this MOST HOLY bracket that ends the next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
			   ArtChar1a.SetActive(false);
		       ArtChar1e.SetActive(true);
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "What do you mean?";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				nextButton.SetActive(true);
                allowSpace = false;

        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Yeah! Sharks love a good party, isn't that right?";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				
        }
		public void Choice2aFunct(){
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Whaaaat? Come on now, don't be so discriminatory. I’m sorry Mr. Shark, my friend here has no idea what they’re talking about.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 299;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
			   ArtChar1e.SetActive(false);
		       ArtChar1d.SetActive(true);
			   ArtChar2a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "AAAAAAAAAAAAAAAAA. QUICK! THE SHIPWRECK OR HARBOR?!?!?";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 399;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(false);
				NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
				allowSpace = true;
        }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene4a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene4b");
        }
}