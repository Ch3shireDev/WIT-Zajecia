function get_message_fragments(mtu, headers, total_size, icmp = 0) {
    let max_data_field = mtu - headers;
    let part_data_size = Math.floor(max_data_field / 8) * 8;
    let remaining_data = total_size + icmp;
    let offset = 0;

    let answers = [];

    while (remaining_data > 0) {
        let part_size = Math.min(part_data_size, remaining_data);
        remaining_data -= part_size;
        let message = remaining_data > 0 ? "MF" : "LF";

        answers.push({
            size: part_size,
            offset: offset,
            message: message
        });

        offset += part_size;
    }
    return answers;
}
const assert = require('assert');

assert.deepEqual(get_message_fragments(576, 20, 1800, 8), [
    { size: 552, offset: 0, message: "MF" },
    { size: 552, offset: 552, message: "MF" },
    { size: 552, offset: 1104, message: "MF" },
    { size: 152, offset: 1656, message: "LF" },
]);

assert.deepEqual(get_message_fragments(296, 20, 1000), [
    { size: 272, offset: 0, message: "MF" },
    { size: 272, offset: 272, message: "MF" },
    { size: 272, offset: 544, message: "MF" },
    { size: 184, offset: 816, message: "LF" },
]);

assert.deepEqual(get_message_fragments(296, 20, 900, 8), [
    { size: 272, offset: 0, message: "MF" },
    { size: 272, offset: 272, message: "MF" },
    { size: 272, offset: 544, message: "MF" },
    { size: 92, offset: 816, message: "LF" },
])

let mtu = 576;
let total_size = 1950;
let headers = 20;
let icmp = 8;
get_message_fragments(mtu, headers, total_size, icmp).forEach(function(x) {
    console.log(`${x.size}@${x.offset}${x.message}`);
});