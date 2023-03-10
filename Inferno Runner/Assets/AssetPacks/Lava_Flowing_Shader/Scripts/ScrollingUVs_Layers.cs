using UnityEngine;
using System.Collections;

public class ScrollingUVs_Layers : MonoBehaviour 
{
	public Vector2 uvAnimationRate = new Vector2( 1.0f, 0.0f );
	public string textureName = "_MainTex";
	
	Vector2 uvOffset = Vector2.zero;

	Renderer render;

	private void Awake() 
	{
		render = GetComponent<Renderer>();
	}
	
	void LateUpdate() 
	{
		uvOffset += (uvAnimationRate * Time.deltaTime);
		if(render.enabled)
		{
			render.sharedMaterial.SetTextureOffset(textureName, uvOffset);
		}
	}
}