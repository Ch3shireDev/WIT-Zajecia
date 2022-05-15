package example;

public class HttpRequest {

    String header;
    String body;

    public HttpRequest() {

    }
    public HttpRequest(String request) {
        if (request == null) return;
        String[] parts = request.split("\r\n\r\n");
        if (parts.length > 0) header = parts[0];
        if (parts.length > 1) body = parts[1];
    }

    String getBody() {
        return body;
    }

    void setBody(String body) {
        this.body = body;
    }
}
