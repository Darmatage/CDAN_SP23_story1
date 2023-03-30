using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3bDialogue : MonoBehaviour {
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

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		ArtChar1d.SetActive(false);
		ArtChar1e.SetActive(false);
		ArtChar2a.SetActive(false);
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
        }
        else if (primeInt == 2){
               ArtChar2a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "NARRATOR";
                Char1speech.text = "*You find a hook with a lil worm on it.*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
		       ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Well hello friend!  Want to go to my party?";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Worm";
                Char3speech.text = "Wish I could fishie fish, but I can't seem to get anywhere stuck on this thingy thang.";
        }
       else if (primeInt == 5){
		       ArtChar1a.SetActive(false);
		       ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "That’s no bother, here, lemme help y-";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
				Choice1a.SetActive(true);
                Choice1b.SetActive(true);
                //gameHandler.AddPlayerStat(1);
				
	    }		
// ENCOUNTER AFTER CHOICE #1A
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Worm wants to party...?";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
				Choice2a.SetActive(true);
                Choice2b.SetActive(true);
				
// AFTER CHOICE 1B
        }
       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(true);
                allowSpace = false;		

				SceneManager.LoadScene("End_Lose2");
        
				
        }
// AFTER CHOICE 2A
        

		else if (primeInt == 300){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Don't you realize that NFTs create no value..  They merely redistribute wealth amongst the rich.";
				Char3name.text = "";
                Char3speech.text = "";
                allowSpace = false;

        }
		else if (primeInt == 301){
			ArtChar1e.SetActive(false);
		       ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Come on friend, let's go, we don't need this worm at our party.";
				Char3name.text = "";
                Char3speech.text = "";
                allowSpace = false;

        }
		else if (primeInt == 302){
			ArtChar2a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Should we check that super spooky shipwreck or the totally normal harbor?";
				Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
// AFTER CHOICE 2B
        
       else if (primeInt == 400){
		   ArtChar2a.SetActive(false);
		   ArtChar1b.SetActive(false);
                Char1name.text = "NARRATOR";
                Char1speech.text = "*The moment Fish touches the hook, he’s flung up and out of water. He’s gone.*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(true);
                allowSpace = false;
	    }		
	   else if (primeInt == 401){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(true);
                allowSpace = false;
				
				
				SceneManager.LoadScene("End_Lose2");
        }

      //Please do NOT delete this MOST HOLY bracket that ends the next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
			   ArtChar1d.SetActive(false);
		       ArtChar1e.SetActive(true);
                Char1name.text = "";
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "But why?";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
			ArtChar1d.SetActive(false);
			ArtChar2a.SetActive(false);
                Char1name.text = "NARRATOR";
                Char1speech.text = "*The moment Fish touches the hook, he’s flung up and out of water. He’s gone.*";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice2aFunct(){
			ArtChar1d.SetActive(false);
		       ArtChar1e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "Oh god really? Yucky...";
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
		       ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Fish";
                Char2speech.text = "How can friendship and shiny things be dangerous? Leave it to me, new friend!";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 399;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene4a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene4b");
        }
               
}