using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vacuumBoxScript : MonoBehaviour
{

    public Slider slider;

    public void setMaxFill(int maxFill)
    {
        slider.maxValue = maxFill;
    }

    public void setFill(int fill)
    {
        slider.value = fill;
    }
}
