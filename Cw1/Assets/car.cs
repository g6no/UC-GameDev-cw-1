using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    string heroName = "Ahmad";
    int heroHeight = 210;
    int heroAge = 21;
    string heroSuperPower = "Unity";

    string villainName = "Taleb";
    int villainHeight = 110;
    int villainAge = 20;
    string villainSuperPower = "Ugly Car";



    // Start is called before the first frame update
    void Start()
    {
        print("The hero's name is " + heroName + " his height is " + heroHeight + " his age is " + heroAge +" his superpower is " + heroSuperPower);
        print("The villain's name is " + villainName + " his height is " + villainHeight + " his age is " + villainAge + " his superpower is " + villainSuperPower);

        int ageDifference = heroAge - villainAge;

        heroHeight = heroHeight + 5;
        heroHeight += 5;

        villainSuperPower = "None";

        print("The hero's name is " + heroName + " his height is " + heroHeight + " his age is " + heroAge + " his superpower is " + heroSuperPower);
        print("The villain's name is " + villainName + " his height is " + villainHeight + " his age is " + villainAge + " his superpower is " + villainSuperPower);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
