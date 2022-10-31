using UnityEngine;

public class Powerup_DoubleJump : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			collision.gameObject.GetComponent<Player>().canDoubleJump = true;
			this.GetComponent<Collider2D>().enabled = false;
			this.GetComponent<SpriteRenderer>().enabled = false;
			AudioSource audio = this.GetComponent<AudioSource>();
			audio.Play();
			Destroy(this.gameObject, audio.clip.length);
		}
	}
}
