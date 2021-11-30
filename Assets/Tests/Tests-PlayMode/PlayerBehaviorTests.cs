using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class PlayerBehaviorTests
{
    private GameObject testObject;

    [SetUp]
    public void Setup()
    {
        testObject = GameObject.Instantiate(new GameObject());        
    }

    [UnityTest]
    public IEnumerator PlayerMovesCorrectDirectionOnInput()
    {
        testObject.AddComponent<PlayerBotMovement>();
        PlayerBotMovement pbm = testObject.GetComponent<PlayerBotMovement>();
        pbm.moveSpeed = 5f;
        pbm.moveVal = new Vector2(0f, 1f);
                
        yield return new WaitForSeconds(1f);

        Assert.IsTrue(testObject.transform.position.y > 0 && testObject.transform.position.x == 0);

    }
}
