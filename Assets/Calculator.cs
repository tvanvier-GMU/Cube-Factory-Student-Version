using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {
	public Text mainDisplay; // The unity component that displays our working value
	public Text historyDisplay; // The unity component that displays the previous value

	[Header("Operation")]
	public double historyDisplayValue; // The actual numerical value of our history display
	public MathOperation operation = MathOperation.NULL;
	public double mainDisplayValue; // The actual numerical value of our main display

	[Header("Last Button Hit")]
	public ButtonType lastButtonType = ButtonType.NULL; 

	string tempNumber;

	public enum MathOperation{
		NULL,
		Add,
		Subtract,
		Multiply,
		Divide,
		Modulo,
		Exponent
	}

	public enum ButtonType{
		NULL,
		Equate,
		Number,
		MathFunction
	}

	// Use this for initialization
	void Start () {
		Clear();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NumpadEntry(string digit){

	}

	public void DecimalEntry(){

	}

	public void AdditionButton(){

	}

	public void SubtractionButton(){

	}

	public void MultiplicationButton(){

	}

	public void DivisionButton(){

	}

	public void ExponentButton(){

	}

	public void ModuloButton(){

	}

	public void NegateButton(){

	}
		
	public void Equate(){

	}

	public void Clear(){
		mainDisplay.text = "0";
		historyDisplay.text = "";
		mainDisplayValue = 0;
		historyDisplayValue = 0;
		lastButtonType = ButtonType.NULL;
		operation = MathOperation.NULL;
	}

}
