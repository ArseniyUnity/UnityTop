public Rigidbody2D rb;
public LayerMask gnd;
public Collider2D coll;

  void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        coll = gameObject.GetComponent<PolygonCollider2D>();
    }

void Update()
    {
        rb.velocity = new Vector2 (speed, rb.velocity.y); // постоянное движение со скоростью speed по х
        rb.velocity = new Vector2 (rb.velocity.x, jump); // постоянное движение со скоростью jump по у


         if(Input.GetKey(KeyCode.Space) && coll.IsTouchingLayers(gnd)){ // если игрок касатся земли и нажат пробел
            rb.velocity = new Vector2 (rb.velocity.x, jump); // реализация прыжка
        }
    }