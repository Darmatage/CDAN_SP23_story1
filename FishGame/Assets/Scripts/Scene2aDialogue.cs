 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2aDialogue : MonoBehaviour {
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
                Char1speech.text = "*You've arrived at the coral. It's beautiful. But there don't seem to be any fish aroun-*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt ==3){
				ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Hi!!! Wanna come to a birthday party?";
				Char3name.text = "";
				Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
		   		ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Coral";
				Char3speech.text = "Party? You want me to go to a party!?";
	   }
				
	   else if (primeInt == 5){
		   		ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Coral";
				Char3speech.text = "Are you blind?!  Don't you have eyes??";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Yes! They're on my face. I grew them all by myself.";
				Char3name.text = "";
				Char3speech.text = "";
				Choice1a.SetActive (true);
				Choice1b.SetActive (true);
                //gameHandler.AddPlayerStat(1);
      
        }

	 // after choice 1a
       else if (primeInt == 20){
		   ArtChar2a.SetActive(false);
		   ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text ="Coral";
				Char3speech.text = "A ROCK?? A ROCK??!? AAAAAAAH";
	
	    }
	   else if (primeInt == 21){
		   ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text ="Coral";
            SceneManager.LoadScene("End_Lose3");

		}

	 
	 // after choice 1b
       else if (primeInt == 38){
		   ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Coral";
				Char3speech.text = "I'm sure i'd go IF I COULD MOVE!";
				
        }
		else if (primeInt == 39){
				Choice2a.SetActive (true);
				DialogueDisplay.SetActive(false);
				nextButton.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text ="";
				Char3speech.text = "";
		}

	 // after choice 2a
       else if (primeInt == 40){
		   Choice2a.SetActive (false);
		   nextButton.SetActive(true);
		   DialogueDisplay.SetActive(true);
		   ArtChar2a.SetActive(false);
		   ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text ="Coral";
				Char3speech.text = "You would do that? For me? I-I can really go to a party?";
        }
       else if (primeInt == 41){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "That's a great idea!!!";
				Char3name.text = "";
				Char3speech.text = "";

		}
	
		else if (primeInt == 42){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Wait here while we go find more guests!";
				Char3name.text = "";
				Char3speech.text = "";
        
        }
		
		else if (primeInt == 43){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Where should we go next?";
				Char3name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
	 

		   
		
	// final scene selection
       else if (primeInt == 60){
		   ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Where next? There is a cool if terrifying cave over there...";
				Char3name.text = "";
				Char3speech.text = "";
        }
		
		 else if (primeInt == 61){
			ArtChar2a.SetActive(false);
			ArtChar2c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Or I see something shiny in that other direction...";
				Char3name.text = "";
				Char3speech.text = "";
		}		
		else if (primeInt == 62){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
		
		
		
	// do not delete the most holy bracket:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Coral";
				Char3speech.text = "A ROCK?? A ROCK??!? AAAAAAAH";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Coral";
				Char3speech.text = "I’m sure it WOULD be IF I COULD MOVE";
                primeInt = 38;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;

        }

        public void Choice2aFunct(){
				GameHandler.coralFriend = true;
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                primeInt = 39;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                primeInt = 49;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }



        public void SceneChange1(){
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3b");
        }
}