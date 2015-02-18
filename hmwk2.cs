u s i n g   S y s t e m ;  
  
 n a m e s p a c e   I n t r o C S  
 {  
       c l a s s   M a i n C l a s s  
       {  
             p u b l i c   s t a t i c   v o i d   M a i n   ( s t r i n g [ ]   a r g s )  
             {  
                 C o n s o l e . W r i t e L i n e ( " T h i s   C a l c u l a t o r   w i l l   h e l p   y o u   d e t e r m i n e   a   g r a d e   i n   a   g i v e n   c l a s s . \ n " ) ;  
                 g e t W e i g h t s ( ) ;  
                 g e t A v e r a g e s ( ) ;  
             }  
             / / p r o m p t s   u s e r   f o r   w e i g h t s ,   t e s t s   i f   a d d s   t o   1 0 0 ,   l o o p s   b a c k   i f   t e s t   f a i l s  
             p u b l i c   s t a t i c   v o i d   g e t W e i g h t s ( )  
             {  
                 C o n s o l e . W r i t e L i n e ( " B e g i n   b y   e n t e r i n g   i n d i v i d u a l   c a t e g o r y   w e i g h t s ,   t h e y   m u s t   a d d   t o   1 0 0 % \ n " ) ;  
                 d o u b l e   w e i g h t S u m   =   0 ;  
                 d o {  
                     d o u b l e   e x a m W e i g h t   =   F i n d W e i g h t ( " e x a m " ) ;  
                     d o u b l e   p r o j e c t W e i g h t   =   F i n d W e i g h t ( " p r o j e c t " ) ;  
                     d o u b l e   l a b W e i g h t   =   F i n d W e i g h t ( " l a b " ) ;  
                     d o u b l e   h o m e w o r k W e i g h t   =   F i n d W e i g h t ( " h o m e w o r k " ) ;  
                     d o u b l e   p a r t i c i p a t i o n W e i g h t   =   F i n d W e i g h t ( " p a r t i c i p a t i o n   p o i n t " ) ;  
                     w e i g h t S u m   =   ( e x a m W e i g h t   +   p r o j e c t W e i g h t   +   l a b W e i g h t   +   h o m e w o r k W e i g h t   +   p a r t i c i p a t i o n W e i g h t ) ;  
                     i f   ( w e i g h t S u m   = =   1 0 0 )   {  
                         C o n s o l e . W r i t e L i n e   ( " C o n g r a t u l a t i o n s !   W e i g h t s   a d d   t o   1 0 0 % \ n " ) ;  
                     }   e l s e {  
                             C o n s o l e . W r i t e L i n e ( " S o r r y   w e i g h t s   d i d   n o t   a d d   t o   1 0 0 % ,   p l e a s e   t r y   a g a i n . \ n " ) ;  
                         }  
                 } w h i l e ( w e i g h t S u m   ! =   1 0 0 ) ;  
             }  
             / / p r o m p t s   u s e r   f o r   w e i g h t s   o f   e a c h   c a t e g o r y  
             p u b l i c   s t a t i c   d o u b l e   F i n d W e i g h t ( s t r i n g   w e i g h t P r o m p t )  
             {  
                 d o u b l e   w e i g h t   =   U I . P r o m p t D o u b l e ( " P l e a s e   e n t e r   t h e   w e i g h t   o f   "   +   w e i g h t P r o m p t   +   " ( s ) :   " ) ;  
                 r e t u r n   w e i g h t ;  
             }  
             / / g e t s   a n d   a s s i g n s   a v e r a g e   g r a d e s   o f   e a c h   c a t e g o r y  
             p u b l i c   s t a t i c   v o i d   g e t A v e r a g e s ( )  
             {  
                 d o u b l e   e x a m A v e r a g e   =   F i n d A v e r a g e ( " e x a m " ) ;  
                 d o u b l e   p r o j e c t A v e r a g e   =   F i n d A v e r a g e ( " p r o j e c t " ) ;  
                 d o u b l e   l a b A v e r a g e   =   F i n d A v e r a g e ( " l a b " ) ;  
                 d o u b l e   h o m e w o r k A v e r a g e   =   F i n d A v e r a g e ( " h o m e w o r k   a s s i g n m e n t " ) ;  
                 d o u b l e   p a r t i c i p a t i o n A v e r a g e   =   F i n d A v e r a g e   ( " p a r t i c i p a t i o n   p o i n t " ) ;  
             }  
             / / p r o m p t s   f o r   i n d i v i d u a l   g r a d e s   a n d   c o m p u t e s   a v e r a g e   s c o r e   f o r   e a c h   c a t e g o r y   t h a t   i s   p a s s e d   i n  
             p u b l i c   s t a t i c   d o u b l e   F i n d A v e r a g e ( s t r i n g   g r a d e P r o m p t )  
             {  
                 d o u b l e   n u m b e r O f G r a d e s   =   U I . P r o m p t D o u b l e ( " P l e a s e   e n t e r   t h e   n u m b e r   o f   "   +   g r a d e P r o m p t   +     " ( s )   t o   g r a d e :   " ) ;  
                 d o u b l e   i   =   1 ;  
                 d o u b l e   t o t a l S c o r e   =   0 ;  
                   d o {  
                     d o u b l e   s c o r e   =   U I . P r o m p t D o u b l e ( " P l e a s e   e n t e r   t h e   g r a d e   o f   a s s i g n m e n t   "   +   i   +   " :   " ) ;  
                     i + + ;  
                     t o t a l S c o r e   + =   s c o r e ;  
                 }   w h i l e   ( i   < =   n u m b e r O f G r a d e s ) ;  
                   r e t u r n   t o t a l S c o r e   /   n u m b e r O f G r a d e s ;  
             }  
  
 	 	 / / a d d e d   t h i s   f u n c t i o n   t o   a s s i g n   g r a d e s   C A M  
 	 	 s t a t i c   v o i d   G r a d e A s s i g n m e n t s ( )  
 	 	 {  
 	 	 s t r i n g   L e t t e r G r a d e M s g ,   G r a d e L e t t e r ;  
 	 	 d o u b l e   g r a d e   =   ( ( E x a m s W e i g h t   *   E x a m s G r a d e   +   H o m e w o r k W e i g h t   *   H o m e w o r k G r a d e   +   L a b s W e i g h t   *   L a b s G r a d e   +   P r o j e c t W e i g h t   *   P r o j e c t G r a d e  
 	 	 	 	 +   P a r t i c i p a t i o n W e i g h t   *   P a r t i c i p a t i o n G r a d e )   /   1 0 0 . 0 0 ) ;  
 	 	  
 	 	 	 i f   ( g r a d e   = =   1 0 0 ) {  
 	 	 	 G r a d e L e t t e r   =   " ,   a n   A +   " ;  
 	 	 }  
 	 	 e l s e   i f   ( g r a d e   > =   9 3 )   {  
 	 	 	 G r a d e L e t t e r   =   " ,   a n   A   " ;  
 	 	 }  
 	 	 e l s e   i f   ( g r a d e   > =   9 0 )   {  
 	 	 	 G r a d e L e t t e r   =   " ,   a n   A -   " ;  
 	 	 }  
 	 	 e l s e   i f   ( g r a d e   > =   8 7 )   {  
 	 	 	 G r a d e L e t t e r   =   " ,   a   B +   " ;  
 	 	 }  
 	 	 e l s e   i f   ( g r a d e   > =   8 3 )   {  
 	 	 	 G r a d e L e t t e r   =   " ,   a   B   " ;  
 	 	 }  
 	 	 e l s e   i f   ( g r a d e   > =   8 0 )   {  
 	 	 	 G r a d e L e t t e r   =   " ,   a   B -   " ;  
 	 	 }  
 	 	 e l s e   i f   ( g r a d e   > =   7 7 )   {  
 	 	 	 G r a d e L e t t e r   =   " ,   a   C +   " ;  
 	 	 }  
 	 	 e l s e   i f   ( g r a d e   > =   7 3 )   {  
 	 	 	 G r a d e L e t t e r   =   " ,   a   C   " ;  
 	 	 }  
 	 	 e l s e   i f   ( g r a d e   > =   7 0 )   {  
 	 	 	 G r a d e L e t t e r   =   " ,   a   C -   " ;  
 	 	 }  
 	 	 e l s e   i f   ( g r a d e   > =   6 7 )   {  
 	 	 	 G r a d e L e t t e r   =   " ,   a   D +   " ;  
 	 	 }  
 	 	 e l s e   i f   ( g r a d e   > =   6 3 )   {  
 	 	 	 G r a d e L e t t e r   =   " ,   a   D   " ;  
 	 	 }  
 	 	 e l s e   i f   ( g r a d e   > =   6 0 )   {  
 	 	 	 G r a d e L e t t e r   =   " ,   a   D -   " ;  
 	 	 }  
 	 	 e l s e   {  
 	 	 	 G r a d e L e t t e r   =   " .   I t   i s   s o   l o w   t h a t   y o u   a r e   u n l i k e l y   t o   p a s s   " ;  
 	 	 }  
 	 	 L e t t e r G r a d e M s g   =   G r a d e L e t t e r ;  
 	 	 	 C o n s o l e . W r i t e L i n e ( " Y o u r   g r a d e   i s   "   +   { 0 : F 2 }   +   L e t t e r G r a d e M s g ,   G r a d e ) ;   / / t h e   F 2   m e a n s   r o u n d   t o   2   d e c   p l a c e s  
 	  
 	 	 }  
 	 }  
 	 }  
 }  
 