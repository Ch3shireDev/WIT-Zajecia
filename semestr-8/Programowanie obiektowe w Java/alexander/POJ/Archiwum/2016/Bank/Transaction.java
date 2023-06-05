
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.time.Instant;
import java.util.Date;

/**
 *
 * @author lipinskb
 */
public class Transaction implements Serializable, Comparable<Transaction>
{
    private long _value;
    private String _id;
    private String _host;
    private String _port;
    private TransactionState _state;
    private Date _time;
    
    public Transaction(long value, String host, String port, String id)
    {
        _value = value;
        _host = host;
        _port = port;
        _id = id;
        _state = TransactionState.Initialized;
        _time = Date.from(Instant.now());
    }
    
    public Transaction(Transaction t, boolean error)
    {
        _value = t._value;
        _host = t._host;
        _port = t._port;
        _id = t._id;
        
        if(error)
            _state = TransactionState.NotOK;
        else
        {
            switch(t._state)
            {
                case Initialized:
                    _state = TransactionState.Recieved;
                    break;
                case Recieved:
                    _state = TransactionState.Confirmed;
                    break;
                case Confirmed:
                    _state = TransactionState.OK;
                    break;
                case OK:
                    _state = TransactionState.OKConfirmed;
                    break;
                case NotOK:
                    _state = TransactionState.NotOKConfirmed;
                    break;
            }
        }

        _time = Date.from(Instant.now());
    }
    
    public long getValue()
    {
        return _value;
    }
    
    public String getHost()
    {
        return _host;
    }
    
    public String getPort()
    {
        return _port;
    }
    
    public String getId()
    {
        return _id;
    }
    
    public static Transaction FromByteArray(byte[] data) throws IOException, ClassNotFoundException
    {
        ByteArrayInputStream stream = new ByteArrayInputStream(data);
        ObjectInputStream in = new ObjectInputStream(stream);
        return (Transaction) in.readObject();
    }
    
    public static byte[] ToByteArray(Transaction t) throws IOException, ClassNotFoundException
    {
        ByteArrayOutputStream mem = new ByteArrayOutputStream();
        ObjectOutputStream out = new ObjectOutputStream(mem);
        out.writeObject(t);
        
        return mem.toByteArray();
    }

    @Override
    public int compareTo(Transaction t) {
        return 0;
        //return (A>B)?1:0)-(A<B?1:0)
    }
}

enum TransactionState {
    Initialized(0),
    Recieved(1),
    Confirmed(2),
    OK(3),
    OKConfirmed(4),
    NotOK(9),
    NotOKConfirmed(10);
    
    private final int Id;
    
    TransactionState(int id)
    {
        this.Id = id;
    }
    
    public int getValue()
    {
        return Id;
    }
}
