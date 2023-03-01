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
               ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(true);
				DialogueDisplay.SetActive(true);
                Char1name.text = "Fish";
                Char1speech.text = "Hey look! A dolphin!!!";
                Char2name.text = "Dolphin";
                Char2speech.text = "Yo! Watch this!";
        }
       else if (primeInt ==3){
                Char1name.text = "Fish";
                Char1speech.text = "WOOooow. That’s really neat!";
                Char2name.text = "Dolphin";
                Char2speech.text = "You like my moves?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "Fish";
                Char1speech.text = "Sure! You could be the entertainment at my party!";
                Char2name.text = "Dolphin";
                Char2speech.text = "Entertainment?";
        }
       else if (primeInt == 5){
                Char1name.text = "Fish";
                Char1speech.text = "Yeah, do your little dances at my party!";
                Char2name.text = "Dolphin";
                Char2speech.text = "Little?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "Fish";
                Char1speech.text = "I’m sure everyone will love it!";
                Char2name.text = "Dolphin";
                Char2speech.text = "...";
        }
       else if (primeInt ==7){
                Char1name.text = "Fish";
                Char1speech.text = "Sooooo, what do you say?";
                Char2name.text = "Dolphin";
                Char2speech.text = "Hmmm...";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Dolphin";
                Char2speech.text = "Y’know I could teach you these tricks if you’d like. It won’t take long…";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Then you are no use to me, and must be silenced.";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Come back here! Do not think you can hide from me!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Jeda";
                Char2speech.text = "Do not think you can fool me, human. Where will we find him?";
        }
       else if (primeInt == 201){
                Char1name.text = "YOU";
                Char1speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

      //Please do NOT delete this MOST HOLY bracket that ends the next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I don't know what you're talking about!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Sure, anything you want... just lay off the club.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}
