using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchScreen : MonoBehaviour
{
    public Animator fadeAnim;
    public Animator companyTxtAnim, gamenameTxtAnim, autosaveTxtAnim, earlyaccessTxtAnim;
    public GameObject companyText, gamenameText, autosaveText, earlyaccessText;

    void Start()
    {
        StartCoroutine(LogoScenes());
    }

    IEnumerator LogoScenes()
    {
        companyText.SetActive(true);
        Invoke("companyTextAnim", 5f);

        yield return new WaitForSeconds(6f);

        companyText.SetActive(false);
        gamenameText.SetActive(true);
        Invoke("gamenameTextAnim", 5f);

        yield return new WaitForSeconds(6f);

        gamenameText.SetActive(false);
        autosaveText.SetActive(true);
        Invoke("autosaveTextAnim", 5f);

        yield return new WaitForSeconds(6f);

        autosaveText.SetActive(false);
        earlyaccessText.SetActive(true);
        Invoke("earlyaccessTextAnim", 5f);

        yield return new WaitForSeconds(6f);

        fadeAnim.SetTrigger("FadeOut");

        yield return new WaitForSeconds(6f);

        SceneManager.LoadScene("MainMenu");
    }

    #region ANIM_TRIGGER
    void companyTextAnim()
    {
        companyTxtAnim.SetTrigger("textFadeOut");
    }
    void gamenameTextAnim()
    {
        gamenameTxtAnim.SetTrigger("textFadeOut");
    }
    void autosaveTextAnim()
    {
        autosaveTxtAnim.SetTrigger("textFadeOut");
    }
    void earlyaccessTextAnim()
    {
        earlyaccessTxtAnim.SetTrigger("textFadeOut");
    }
    #endregion
}