 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2bDialogue : MonoBehaviour {
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
			   ArtChar1c.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Hellooo?  Anybody in there?";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Unknown Voice";
				Char3speech.text = "EEP!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
		   	   ArtChar1c.SetActive(false);
			   ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Eep?";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 5){
		   ArtChar2a.SetActive(true);
                Char1name.text = "NARRATOR";
                Char1speech.text = "*A clownfish timidly emerges from the anemone...*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Clownfish";
				Char3speech.text = "W-w-w-whaddya want?";
        }
       else if (primeInt ==7){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "I want you to come to my party!";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Clownfish";
				Char3speech.text = "M-m-muh..  Me?..  But why?";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
		   ArtChar2a.SetActive(false);
		   ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text ="Clownfish";
				Char3speech.text = "You think I would make the party more merry?";
        }
 
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Clownfish";
				Char3speech.text = "Of course I'll be there!";
        }
       else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Great!  A new friend!  Let's keep going!";
				Char3name.text = "";
				Char3speech.text = "";
	   }		
		else if (primeInt == 103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Where should we go next? I see something shiny over there! And a cave!";
				Char3name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
     
	 
	 // ENCOUNTER AFTER CHOICE #2

		
		       else if (primeInt == 200){
			ArtChar2a.SetActive(false);
			ArtChar2c.SetActive(false);
                Char1name.text = "NARRATOR";
                Char1speech.text = "*The clownfish solomly swimms back into the anemone.*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
	
	}		
       else if (primeInt == 201){
                Char1name.text = "NARRATOR";
                Char1speech.text = "*Guess he's not much of a party animal..*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
	   }		
		else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Come on, let's go check out that shiny thing or the cave!";
				Char3name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Clownfish";
				Char3speech.text = "Really??";
                primeInt = 99;
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
				Char3name.text = "Clownfish";
				Char3speech.text = "You think I'm a joke..  Just like everybody else..";
                primeInt = 199;
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