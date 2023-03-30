using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
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
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       next();
                }
        }
   }

//Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
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
                Char1speech.text = "Hey! He kinda looks just like you!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar1d.SetActive(false);
				ArtChar1a.SetActive(true);
				ArtChar2a.SetActive(false);
				ArtChar2b.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Scuba Dude";
                Char2speech.text = "Well, hello there!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
				ArtChar2b.SetActive(false);
				ArtChar2a.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Hi! What are you doing Mr?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar2a.SetActive(false);
				ArtChar2b.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Scuba Dude";
                Char2speech.text = " I’m doing research!Studying the world of the ocean!";
        }
       else if (primeInt == 6){
                ArtChar1b.SetActive(false);
				ArtChar1a.SetActive(true);
				ArtChar2b.SetActive(false);
				ArtChar2a.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Gee whiz, that’s really nifty! ";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                ArtChar2a.SetActive(false);
				ArtChar2b.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Scuba Dude";
                Char2speech.text = " It is! I get to learn about your species. For example, the Anarhichas lupus";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Scuba Dude";
                Char2speech.text = "can create its own antifreeze proteins!";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Nah, it's nerdy.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 21){
                //gameHandler.AddPlayerStat(1);
                 ArtChar2b.SetActive(false);
				ArtChar2c.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Scuba Dude";
                Char2speech.text = "Whatever, I’m going to continue my research!";
        }
       else if (primeInt == 22){
                ArtChar2c.SetActive(false);
				ArtChar1b.SetActive(false);
				ArtChar1d.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "What a nerdy guy!";
                Char2name.text = "";
                Char2speech.text = "";
				
	    }
       else if (primeInt == 23){
                ArtChar1d.SetActive(false);
				ArtChar1c.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Bout time for the party, dontcha think?";
                Char2name.text = "";
                Char2speech.text = "";
				
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Sure is! Hey I know! Why not join our party?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		else if (primeInt == 31){
                ArtChar2a.SetActive(false);
				ArtChar2c.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Scuba Dude";
                Char2speech.text = "Party?";
        }
       
	   else if (primeInt == 32){
                Char1name.text = "Fish";
                Char1speech.text = "Well yeah! I’m sure everyone else would like to learn some cool facts!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       
	   else if (primeInt == 33){
                ArtChar2c.SetActive(false);
				ArtChar2a.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Scuba Dude";
                Char2speech.text = "Of course! I’d love to join!";
        }
       
	   else if (primeInt == 34){
                ArtChar1b.SetActive(false);
				ArtChar1a.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Neat-o! See you are the coral reef scuba dude!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       
	   else if (primeInt == 35){
                ArtChar2a.SetActive(false);
				ArtChar1a.SetActive(false);
				ArtChar1c.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "It’s just about time for the party to start dontcha think?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

      //Please do NOT delete this final bracket that ends the next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Scuba Dude";
                Char2speech.text = "Hey! It’s not nerdy! It’s knowledge!";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                ArtChar2b.SetActive(false);
				ArtChar2a.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Scuba Dude";
                Char2speech.text = " It is quite fascinating isn’t it?";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene6");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}