using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6Dialogue : MonoBehaviour {
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
       public GameObject ArtChar2;
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
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "NARRATOR";
                Char3speech.text = "*You help set up the party with fish*";
        }
       else if (primeInt ==3){
                ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Well, I am very grateful to you!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "Fish";
                Char1speech.text = "I couldn’t have done this on my own.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "Fish";
                Char1speech.text = "To be honest, I didn’t have many friends to begin with.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 6){
                ArtChar1b.SetActive(false);
				ArtChar1d.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "NARRATOR";
                Char3speech.text = "*You notice Fish becoming emotional*";
        }
       else if (primeInt ==7){
                ArtChar1d.SetActive(false);
				ArtChar1e.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Well...I didn't have any friends actually.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 8){
                ArtChar1e.SetActive(false);
				ArtChar1b.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "but with you, I think of you as my best friend.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Fish";
                Char1speech.text = "I’m overjoyed to see you see me as your best friend too!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		
		else if (primeInt == 21){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "Fish";
                Char1speech.text = "I can’t wait to do even more parties with you!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		
		else if (primeInt == 22){
                //gameHandler.AddPlayerStat(1);
                ArtChar1b.SetActive(false);
				ArtChar1c.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Well, let’s get this party kickin shall we?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		
		else if (primeInt == 23){
                //gameHandler.AddPlayerStat(1);
                ArtChar1c.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "NARRATOR";
                Char3speech.text = "*You both finish setting up the party*";
        }
		
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
				Char3name.text = "NARRATOR";
                Char3speech.text = "*Guests begin to arrive.*";
        }

       else if (primeInt == 25){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
             SceneManager.LoadScene("End_Win");
        }
		
       // after choice 1b
       else if (primeInt == 30){
                ArtChar1d.SetActive(false);
				ArtChar1e.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Sorry";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		
		else if (primeInt == 31){
                Char1name.text = "Fish";
                Char1speech.text = " I was just rambling.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		
		else if (primeInt == 32){
                ArtChar1e.SetActive(false);
				ArtChar1d.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "You can ignore what I said!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		
		else if (primeInt == 33){
                 ArtChar1d.SetActive(false);
				ArtChar1b.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "I just wanted to make you feel welcomed is all!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		
		else if (primeInt == 34){
                 ArtChar1b.SetActive(false);
				ArtChar1c.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "Let’s finish setting up…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		
		else if (primeInt == 35){
                ArtChar1c.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "NARRATOR";
                Char3speech.text = "*You feel like scum.*";
        }
		
       else if (primeInt == 36){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
             SceneManager.LoadScene("End_Win");
        }

      //Please do NOT delete this final bracket that ends the next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "Fish";
                Char1speech.text = "Oh, well gee!!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                ArtChar1b.SetActive(false);
				ArtChar1d.SetActive(true);
				Char1name.text = "Fish";
                Char1speech.text = "R-right!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Win");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}