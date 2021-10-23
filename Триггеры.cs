void OnTriggerEnter2D(Collider2D other){ // игрок вошёл в триггер, имя триггера = other

    if(other.gameObject.tag == "speed"){ // если у триггера тег = speed, обработка логики
        speed = speed + 5;                         // увеличение скорости
        Destroy(other.gameObject); // уничтожение триггера как обьекта
        //  Destroy(other);  // уничтожение только коллайдера 
    }
    
}
// альтернативные варианции 

void OnTriggerExit2D(Collider2D other){ // запускается в случае выхода из триггера
void OnTriggerStay2D(Collider2D other){ // запускается в случае нахождение игрока в области триггера

