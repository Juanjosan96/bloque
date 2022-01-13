using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class siguientenivel : MonoBehaviour {
    public string cargarnivel;
    public float tiempodecarga;
	
    [ContextMenu("activarcarga")]
    public void activarcarga()
    {
        Invoke("CargandoelNivel", tiempodecarga);
    }
    void CargandoelNivel()
    {
        if (!ultimonivel())
        {
            vidas.Vidas++;
        }
        SceneManager.LoadScene(cargarnivel);
    }
    public bool ultimonivel()
    {
        return cargarnivel == "portada";
        
    }
}
