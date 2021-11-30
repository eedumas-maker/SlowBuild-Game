using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TrashBehaviorTests
{
    private GameObject testObject;

    [SetUp]
    public void Setup()
    {
        testObject = GameObject.Instantiate(new GameObject());
    }

    [UnityTest]
    public IEnumerator TrashThrownInCorrectDirecion()
    {
        yield return new WaitForSeconds(1f);
    }

}
