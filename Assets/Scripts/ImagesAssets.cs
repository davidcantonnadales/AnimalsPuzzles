using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ImageComponent")]
public class ImagesAssets : ScriptableObject {
	[SerializeField] public Texture2D FullImage;
	[SerializeField] public Sprite[] img;
	
}
