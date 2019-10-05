using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GameObject))]
public class PhotoButton : MonoBehaviour {
    public GameObject zoomedPhotoGO;

    void Start() {
        
    }

    void Update() {
        
    }

    public void handleOnClick() {
        Debug.Log("Photo button clicked");
        //enter zoomed photo mode
        Vector3 photoPosition = new Vector3(0f, 0f, 0f);
        GameObject newGo = Object.Instantiate(zoomedPhotoGO, photoPosition, Quaternion.identity);
        Image i = (Image) newGo.GetComponent(typeof(Image));
        // i.sprite = Sprite.Create()
    }
}
