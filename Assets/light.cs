using UnityEngine;

public class light : MonoBehaviour
{
    private Light screen;
    private float flicker = 20;
    private float counter;
    private float delay;
    void Start()
    {
        screen = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(delay == 60)
        {

                screen.enabled = !screen.enabled;
                counter = 0;
                delay = 0;
        }
        delay++;
    }
}
