using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class selecciondenivel : MonoBehaviour {
	public static int nivelestatico = 1;
	public int niveldesbloqueado;
	public string siguientenivel;

    
	void Awake()
	{
		if (PlayerPrefs.HasKey ("Nivel")) {
			nivelestatico = PlayerPrefs.GetInt ("Nivel", nivelestatico);

		       }
	}

	public void ButtonNextLevel()
	        {
		SceneManager.LoadScene (siguientenivel);
		if(nivelestatico <= niveldesbloqueado){
			nivelestatico = niveldesbloqueado;
			PlayerPrefs.SetInt ("Nivel", nivelestatico);

	 }
           }
	public void ButtonMenu()
	{
		SceneManager.LoadScene ("Selección de Nivel");
	}
}
