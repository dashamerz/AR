using UnityEngine;
using UnityEngine.UI;


public class HeroAnimation : MonoBehaviour
{
    private GameObject hero;
    private Animator heroAnimator;
    public Button runButton, stopButton;
    private Vector3 center = new Vector3(0, 0, 0);
    public float speed;

    public void Start()
    {
        hero = GameObject.Find("Hero_00");
        heroAnimator = hero.GetComponent<Animator>();
        runButton.onClick.AddListener(Run);
        stopButton.onClick.AddListener(RunBack);

    }
    public void Run()
    {
        heroAnimator.SetBool("IsRunning", true);
    }
    public void RunBack()
    {
        heroAnimator.SetBool("IsRunning", false);

        //if (transform.position != center)
        //{
        //    heroAnimator.Play("Running");

        //    runButton.interactable = !runButton.interactable;

        //    Color c = runButton.GetComponent<Image>().color;
        //    c.a = 0.5f;
        //    runButton.GetComponent<Image>().color = c;

        //    transform.Translate(Vector3.right);
        //    float step = speed * Time.deltaTime;
        //    transform.position = Vector3.MoveTowards(transform.position, center, step);
        //    transform.position = center;
        //}
        //else
        //{
        //    runButton.interactable = runButton.interactable;

        //    heroAnimator.Play("Idle");
        //}

    }
}