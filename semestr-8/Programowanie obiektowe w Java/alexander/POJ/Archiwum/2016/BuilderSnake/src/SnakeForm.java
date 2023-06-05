
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class SnakeForm extends javax.swing.JFrame implements IntScreen, IntKeyboard, Runnable {

    private KeyKind lastkey = KeyKind.Rt;
    private SnakePart[][] board = null;

    public SnakeForm() {
        initComponents();
        KeyListener kl = new KeyListener() {
            @Override
            public void keyTyped(KeyEvent e) {
            }

            @Override
            public void keyPressed(KeyEvent e) {
                int key = e.getKeyCode();
                switch (key) {
                    case KeyEvent.VK_UP:
                        lastkey = KeyKind.Up;
                        break;
                    case KeyEvent.VK_DOWN:
                        lastkey = KeyKind.Dn;
                        break;
                    case KeyEvent.VK_LEFT:
                        lastkey = KeyKind.Lf;
                        break;
                    case KeyEvent.VK_RIGHT:
                        lastkey = KeyKind.Rt;
                        break;
                }
            }

            @Override
            public void keyReleased(KeyEvent e) {
            }
        };
        addKeyListener(kl);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        FldScore = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setResizable(false);

        FldScore.setText("jLabel1");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(0, 366, Short.MAX_VALUE)
                .addComponent(FldScore))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(FldScore)
                .addGap(0, 286, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    @Override
    public void run() {
        setVisible(true);
    }

    public static void main(String args[]) {
        SnakeBuilder sb = new SnakeBuilder();
        sb.setEnvironmentOption(EnvironmentOption.GUI);
        SnakeEngine Snake = sb.build();
        Runnable run = new Runnable() {
            @Override
            public void run() {
                Snake.getIs().run();
            }
        };
        java.awt.EventQueue.invokeLater(run);
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel FldScore;
    // End of variables declaration//GEN-END:variables
   @Override
    public void setSize(int Widht, int Height) {
        board = new SnakePart[Height][Widht];
    }

    @Override
    public void setScore(int Score) {
        FldScore.setText(""+Score);
    }

    @Override
    public void displayBody(int x, int y) {
        board[y][x] = SnakePart.Body;
    }

    @Override
    public void displayFruit(int x, int y) {
        board[y][x] = SnakePart.Fruit;
    }

    @Override
    public void displayEmpty(int x, int y) {
        board[y][x] = SnakePart.Empty;
    }

    @Override
    public boolean keyUp() {
        return lastkey == KeyKind.Up;
    }

    @Override
    public boolean keyDn() {
        return lastkey == KeyKind.Dn;
    }

    @Override
    public boolean keyLf() {
        return lastkey == KeyKind.Lf;
    }

    @Override
    public boolean keyRt() {
        return lastkey == KeyKind.Rt;
    }
}
