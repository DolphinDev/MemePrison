using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Threading;
/**
 * 
 * 
 * Game Project: MLG Prison
 * 
 * 
 * 
 * 
 * 
 * */
public class TextController : MonoBehaviour {

	public Text desc;
	private enum KeyStates {cell,mirror,note_0,lock_0,note_1,lock_1,freedom,karatechop,rekt
	};
	private KeyStates currState;

	void Start () {
		currState = KeyStates.cell;
	
	
	
	}
	
	// Update is called once per frame
	void Update () {
		print ("Current Game State is  " + currState);
		if (currState == KeyStates.cell) {
		
			cell ();
		} else if (currState == KeyStates.note_0) {
			note_0 ();
		
		} else if (currState == KeyStates.mirror) {
			mirror ();
		} else if (currState == KeyStates.lock_0) {
			sneak ();
		} else if (currState == KeyStates.lock_1) {
			rkthing ();
		
		} else if (currState == KeyStates.freedom) {
			finalize();
		
		}

}
	void cell(){
		
		desc.text = "You were framed by Cool Giy Bear Grylls, You are now in Dank Meme Prison,   "
			+ " You have 3 friend's, Shrek,Doge & a call of duty haxor. " +
				" You are currently in a cell with no mlg doritos, you are distributed an MLG Blunt every 420 hours " +
				" If you 360 someone in the noscope court, you're given an extra blunt" +
				"and some mt dew with a 69 pack of doritos \n\n" 
				+ "You are now in you're cell, the door is guarded by 2 MLG Hackers, there's a note on you're bed," +
				"there's also a mirror so you can remind yourself of how bad you are \n\n"
				+  "L to sneak up on the prison lock, M To look at the mirror, N to read the note." ;
		
		if (Input.GetKeyDown (KeyCode.N)) {
			currState = KeyStates.note_0;

		} else if (Input.GetKeyDown (KeyCode.M)) {
			currState = KeyStates.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			currState = KeyStates.lock_0;
		}
		
	}

	void note_0(){
		desc.text = "Hey there Uncle DoucheBag! I can't belive you got framed! \n\n " +
			"My GTA5 Crew is going to pull a heist so u can escape! \n\n" +
				" - Sincerly, Douchy Jr. \n\n" +
				"You: God damn it Douchy JR! I guess I do have to get revenge on cool giy grylls tho.. \n\n" +
				"Press R to stop reading.";

		if(Input.GetKeyDown(KeyCode.R)){
			currState = KeyStates.cell;
		}
	}

	void mirror(){
		desc.text = "You: Well, atleast I still have my 69 packed abs. \n\n" +
			"Press R to stop looking at the mirror";
		if(Input.GetKeyDown(KeyCode.R)){
			currState = KeyStates.cell;
		}

	}

	void sneak(){
		desc.text = "You: I wonder if the lock is open \n\n" +
			"BINGO! CRAP DON'T NISCIP ME I SWEAR ON MI NAN I'LL REK YOU! \n\n" +
			"Press E to rekt them to mlg Press I to karate niscip them";

		if (Input.GetKeyDown(KeyCode.E)) {
		     desc.text = "*You start chanting the REKT song* \n\n"
				+ "The guards died of you're boring voice... \n\n" +
					"You: FUCK YEAH! \n\n" +
					"Item Accquired: Freedom MLG key";
			currState = KeyStates.lock_1;

		
		} else if(Input.GetKeyDown(KeyCode.I)){
			desc.text = "Due to no one giving a shit, you and you're new friends seized the fuck out of the new guards \n\n"
				+ "Because logic is 0 in this world, donate now to support the doge movement \n\n" +
					"Item Accquired: Freedom MLG key";
			currState = KeyStates.lock_1;
		}

	}
	void rkthing(){
		desc.text = "You use the key you accquired, you unlock every cell, and rally everyone up \n\n" +
			"you: ok giys, we need to kill the owner of this prisonnnzzzz, which is cool giy gryllz \n\n" +
			"press t to go in style, press O to go wITH StYLe";

		if (Input.GetKeyDown (KeyCode.T)) {
			desc.text = "You have succesfully hit the run, now go find that son of a giy";
			currState = KeyStates.freedom;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			desc.text = "You have succesfully hit the run with fucking style, now go destroy dat giy";
			currState = KeyStates.freedom;
		
		}

				

	}

	void finalize(){
		desc.text = "You catch up to Cool Giy grylls, as he's smokin dank piss \n\n" +
			"YOU: HEY THERE FUCKER, IM BACK BITCH, ALL CAPITALIZED ASWELL FUCKER! \n\n"
				+ "Giy Grylls: dafuq u wot m8 I rlyd fooked yo bitch! \n\n" +
				"You: I HAVE YOU'RE WEAKNESS FUCKER! \n\n" +
				"You knock him down and he still keeps on smiling \n\n" +
				"Giy Grylls: So wuts it going to be m8..., kill me or let me live? \n\n" +
				"Press Z to Make him drink you're own piss, Press A to... well its going to be the same thing.";
		if(Input.GetKeyDown(KeyCode.Z)){
			desc.text = "You: GET EVERY FUCKING DROP! \n\n" +
				"YOU: THATS RIGHT GET ALL OF IT! \n\n" +
					"R.I.P Cool Giy Grylls, he died bcuz he didn't drink his own piss...\n\n" +
					"GZ, you did it! PRISON BLOWING UP IN 5 SEGUNDOS!";
			Thread.Sleep(5);
			Application.Quit();

		} else if(Input.GetKeyDown(KeyCode.A)){
			desc.text = "You: GET EVERY FUCKING DROP! \n\n" +
				"YOU: THATS RIGHT GET ALL OF IT! \n\n" +
					"R.I.P Cool Giy Grylls, he died bcuz he didn't drink his own piss...\n\n" +
					"GZ, you did it! PRISON BLOWING UP IN 5 SEGUNDOS!";
			Thread.Sleep(50000);
			Application.Quit();
			 
		}
	}

}
